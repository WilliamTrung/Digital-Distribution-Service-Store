using BusinessObject;
using DataAccess.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace DigitalStoreApp
{
    public partial class AdminManagementControl : UserControl
    {
        int control;
        public Member loginUser;
        ISystemHandler lib;
        DBContext _context;
        class Member_Model {
            public int MemberID { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            public Boolean Ban { get; set; }
            public Boolean Manager { get; set; }
        }
        public AdminManagementControl()
        {
            InitializeComponent();
            lib = new ISystemHandler();
            _context = new DBContext();
        }
        public void PassLoginUser(Member loginUser)
        {
            this.loginUser = loginUser;
        }
        public void SetControlView(int view)
        {
            control = view;
        }

        public void LoadControlView()
        {
            switch (control)
            {
                //Category = 1
                case 1:
                    pnCategoryForProduct.Hide();
                    pnSearchDateForOrder.Hide();
                    break;
                //Product = 2
                case 2:
                    pnSearchDateForOrder.Hide();
                    pnCategoryForProduct.Show();
                    break;
                //Member = 3
                case 3:
                    pnCategoryForProduct.Hide();
                    pnSearchDateForOrder.Hide();
                    break;
                //Order = 4
                case 4:
                    pnSearchDateForOrder.Show();
                    pnCategoryForProduct.Hide();
                    pnSearchName.Hide();
                    pnCUD.Enabled = false;
                    break;
            }
        }
        private void LoadCbCategories()
        {
            var cateList = lib.Categories().GetCategories();
            cateList.Add(new Category()
            {
                CategoryID = -1,
                CategoryName = "All"
            }) ;
            cbCategory.ValueMember = "CategoryID";
            cbCategory.DisplayMember = "CategoryName";

            cbCategory.DataSource = cateList;
        }
        private void LoadAllProducts(List<Product> products)
        {
            var query = (from product in products
                         join category in lib.Categories().GetCategories()
                         on product.CategoryID equals category.CategoryID
                         select new
                         {
                             ID = product.ProductID,
                             Name = product.ProductName,
                             Category = category.CategoryName,
                             InStock = product.UnitsInStock,
                             Price = product.UnitPrice,
                         }).ToList();
            dgvDisplay.DataSource = query;
            dgvDisplay.ReadOnly = true;
            dgvDisplay.Refresh();
        }
        private Member ModelToMember(Member_Model model)
        {
            return new Member
            {
                MemberID=model.MemberID,
                MemberName = model.Name,
                Email = model.Email,
                IsAdmin = model.Manager,
                Status = model.Ban,
                Password = model.Password
            };
        }
        private void LoadAllMembers(List<Member> members)
        {
            //List<Member_Model> models = new List<Member_Model>();
            BindingList<Member_Model> models = new BindingList<Member_Model>();
            foreach(Member member in members)
            {
                models.Add(new Member_Model
                {
                    MemberID = member.MemberID,
                    Name = member.MemberName,
                    Email = member.Email,
                    Password = member.Password,
                    Ban = !member.Status,
                    Manager = member.IsAdmin
                }); 
            }
            models.AllowEdit = true;
            //dgvDisplay.AllowUserToAddRows = true;       
            dgvDisplay.ReadOnly = false;
            dgvDisplay.DataSource = models;
            dgvDisplay.Columns[0].ReadOnly = true;
            dgvDisplay.Columns[1].ReadOnly = true;
            dgvDisplay.Columns[2].ReadOnly = true;
            dgvDisplay.Refresh();
        }
        private void LoadAllOrders(List<Order> orders)
        {
            var query = (from order in orders
                         join member in lib.Members().GetMembers()
                         on order.MemberID equals member.MemberID
                         select new
                         {
                             ID = order.OrderID,
                             CreatedDate = order.OrderDate,
                             Checkout = !order.Status,
                             Creator = member.MemberName,
                             Email = member.Email
                         }).ToList();
            dgvDisplay.DataSource = query;
            dgvDisplay.ReadOnly = true;
            dgvDisplay.Refresh();
        }
        private void LoadAllCategories(List<Category> categories)
        {
            var query = (from category in categories
                         select new
                         {
                             ID = category.CategoryID,
                             Category = category.CategoryName
                         }).ToList();
            dgvDisplay.DataSource = query;
            dgvDisplay.ReadOnly = true;
            dgvDisplay.Refresh();
        }
        private void btLoadAll_Click(object sender, System.EventArgs e)
        {
           switch (control)
           {
                case 1:
                    var categories = lib.Categories().GetCategories();
                    LoadAllCategories(categories);
                    break;
                case 2:
                    var products = lib.Products().GetProducts();
                    LoadCbCategories();
                    LoadAllProducts(products);
                    break;
                case 3:
                    var members = lib.Members().GetMembers();
                    LoadAllMembers(members);
                    break;
                case 4:
                    var orders = lib.Orders().GetOrders();
                    LoadAllOrders(orders);
                    break;
            }
        }

        private void btSortByName_Click(object sender, System.EventArgs e)
        {
            string search = tbSearchName.Text.ToLower();

            switch (control)
            {
                case 1:
                    var categories = lib.Categories().GetCategories().Where(c => c.CategoryName.Contains(search)).OrderBy(c => c.CategoryName).ToList();
                    LoadAllCategories(categories);
                    break;
                case 2:
                    Category category = (Category)cbCategory.SelectedValue;
                    int categoryId = category.CategoryID;
                    List<Product> products = new List<Product>();
                    if (categoryId == -1)
                    {
                        products = lib.Products().GetProducts().Where(p => p.ProductName.ToLower().Contains(search)).ToList();
                    }
                    else
                    {
                        products = lib.Products().GetProducts().Where(p => p.ProductName.Contains(search) && p.CategoryID == categoryId).ToList();
                    }
                    products = products.OrderBy(p=>p.ProductName).ToList();
                    LoadCbCategories();
                    LoadAllProducts(products);
                    break;
                case 3:
                    var members = lib.Members().GetMembers().Where(m => m.MemberName.Contains(search)).OrderBy(m => m.MemberName).ToList();
                    LoadAllMembers(members);
                    break;
            }
        }

        private void btCreate_Click(object sender, System.EventArgs e)
        {
            int id;
            switch (control)
            {
                
                case 1:
                    id = _context.Categories.OrderBy(c => c.CategoryID).Last().CategoryID;                    
                    id += 1;
                    frmCategoryDetail frmCategoryDetail = new frmCategoryDetail(id);
                    frmCategoryDetail.ShowDialog();
                    LoadAllCategories(lib.Categories().GetCategories());
                    break;
                case 2:
                    id = _context.Products.OrderBy(p => p.ProductID).Last().ProductID;
                    id += 1;
                    frmProductDetail frmProductDetail = new frmProductDetail(id);
                    frmProductDetail.ShowDialog();
                    LoadAllProducts(lib.Products().GetProducts());
                    break;
                case 3:
                    id = _context.Members.OrderBy(m => m.MemberID).Last().MemberID;
                    id += 1;
                    frmMemberDetail frmMemberDetail = new frmMemberDetail
                    {
                        loginUser = new Member()
                        {
                            MemberID = id
                        },
                        InsertOrUpdate = false
                    };
                    
                    frmMemberDetail.Closed += delegate
                    {
                        // read from file and update DataGridView
                        LoadAllMembers(lib.Members().GetMembers());
                    };
                    frmMemberDetail.Show();
                    break;
            }
        }
        public void CreateMemberDGV()
        {

        }
        private void btDelete_Click(object sender, System.EventArgs e)
        {
            var selected_row = dgvDisplay.CurrentRow;
            if(selected_row != null)
            {
                var choice = MessageBox.Show("Are you sure to delete?", "Warning", MessageBoxButtons.YesNo);
                if(choice == DialogResult.Yes)
                {
                    string search = tbSearchName.Text.ToLower();
                    int id = Int32.Parse(selected_row.Cells[0].Value.ToString());
                    try
                    {
                        switch (control)
                        {
                            case 1:
                                var category = _context.Categories.Find(id);
                                lib.Categories().Delete(category);
                                //list
                                var categories = lib.Categories().GetCategories().Where(c => c.CategoryName.Contains(search)).OrderBy(c => c.CategoryName).ToList();
                                LoadAllCategories(categories);
                                break;
                            case 2:
                                var product = _context.Products.Find(id);
                                lib.Products().Delete(product);
                                //list 
                                Category cate = (Category)cbCategory.SelectedValue;
                                int categoryId = cate.CategoryID;
                                List<Product> products = new List<Product>();
                                if (categoryId == -1)
                                {
                                    products = lib.Products().GetProducts().Where(p => p.ProductName.ToLower().Contains(search)).ToList();
                                }
                                else
                                {
                                    products = lib.Products().GetProducts().Where(p => p.ProductName.Contains(search) && p.CategoryID == categoryId).ToList();
                                }
                                products = products.OrderBy(p => p.ProductName).ToList();
                                LoadCbCategories();
                                LoadAllProducts(products);

                                break;
                            case 3:
                                var member = _context.Members.Find(id);
                                lib.Members().Delete(member);
                                //list
                                var members = lib.Members().GetMembers().Where(m => m.MemberName.Contains(search)).OrderBy(m => m.MemberName).ToList();
                                LoadAllMembers(members);
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }
                }               
            }
            else
            {
                MessageBox.Show("No record is chosen!", "Notification");
            }
        }

        private void btUpdate_Click(object sender, System.EventArgs e)
        {
            var selected_row = dgvDisplay.CurrentRow;
            if (selected_row != null)
            {
                string cell = selected_row.Cells[0].Value.ToString();
                int id = Int32.Parse(cell);
                try
                {
                    switch (control)
                    {
                        case 1:
                            var category = _context.Categories.Find(id);
                            frmCategoryDetail frmCategoryDetail = new frmCategoryDetail(id);
                            frmCategoryDetail.ShowDialog();
                            LoadAllCategories(lib.Categories().GetCategories());
                            break;
                        case 2:
                            var product = _context.Products.Find(id);
                            frmProductDetail frmProductDetail = new frmProductDetail(id);
                            frmProductDetail.ShowDialog();
                            LoadAllProducts(lib.Products().GetProducts());
                            break;
                        case 3:
                            var member = _context.Members.Find(id);
                            frmMemberDetail frmMemberDetail = new frmMemberDetail()
                            {
                                loginUser = member,
                                InsertOrUpdate = true
                            };
                            LoadAllMembers(lib.Members().GetMembers());
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }

            }
            else
            {
                MessageBox.Show("No record is chosen!", "Notification");
            }
        }

        private void tbSearchName_TextChanged(object sender, System.EventArgs e)
        {
            string search = tbSearchName.Text.ToLower();
            
            switch (control)
            {
                case 1:
                    var categories = lib.Categories().GetCategories().Where(c => c.CategoryName.Contains(search)).ToList();
                    LoadAllCategories(categories);
                    break;
                case 2:
                    Category category = (Category)cbCategory.SelectedValue;
                    int categoryId = category.CategoryID;
                    List<Product> products = new List<Product>();
                    if (categoryId == -1)
                    {
                        products = lib.Products().GetProducts().Where(p => p.ProductName.ToLower().Contains(search)).ToList();
                    }
                    else
                    {
                        products = lib.Products().GetProducts().Where(p => p.ProductName.Contains(search) && p.CategoryID == categoryId).ToList();
                    }
                    LoadAllProducts(products);
                    break;
                case 3:
                    var members = lib.Members().GetMembers().Where(m => m.MemberName.ToLower().Contains(search)).ToList();
                    LoadAllMembers(members);
                    break;
            }
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Category category = (Category)cbCategory.SelectedValue;
                int categoryId = category.CategoryID;
                string search = tbSearchName.Text.ToLower();
                List<Product> products = new List<Product>();
                if(categoryId == -1)
                {
                    products = lib.Products().GetProducts().Where(p => p.ProductName.ToLower().Contains(search)).ToList();
                }
                else
                {
                    products = lib.Products().GetProducts().Where(p => p.ProductName.Contains(search) && p.CategoryID == categoryId).ToList();
                }
                
                LoadAllProducts(products);
            }
            catch
            {

            }
            
            
        }

        private void dgvDisplay_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //for CRUD member
            if(control == 4)
            {
                var row = dgvDisplay.CurrentRow;
                if(row != null)
                {
                    int orderId = Int32.Parse(row.Cells[0].Value.ToString());
                    Order selected = _context.Orders.Find(orderId);
                    Member creator = _context.Members.Find(selected.MemberID);
                    frmBill frmBill = new frmBill
                    {
                        loginUser = this.loginUser,
                        mem = creator,
                        order = selected
                    };
                    frmBill.Show();
                }
                
            }
        }

        private void AdminManagementControl_Load(object sender, EventArgs e)
        {

        }
        private Boolean ValidatePassword(string password)
        {
            Boolean check = true;
            if (password.Trim().Length == 0)
            {
                check = false;
                MessageBox.Show("Password must not be blank!", "Notification");
            }
            if(password.Contains(" "))
            {
                check = false;
                MessageBox.Show("Password must not have space!", "Notification");
            }
            return check;
        }
        private void dgvDisplay_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
            var currentCell = dgvDisplay.CurrentCell;
            var currentRow = dgvDisplay.CurrentRow;
            int colunm = currentCell.ColumnIndex;

            int MemberID = Int32.Parse(currentRow.Cells[0].Value.ToString());
            Member selected = _context.Members.Find(MemberID);
            Boolean check = false;
            if (colunm == 3)
            {
                string password = currentCell.Value.ToString();
                if (ValidatePassword(password))
                {
                    selected.Password = password;
                    check = true;
                }
            }
            else if(colunm == 4)
            {
                Boolean current_status = selected.Status;
                selected.Status = !current_status;
                check = true;
            }
            else
            {
                Boolean current_isAdmin = selected.IsAdmin;
                selected.IsAdmin = !current_isAdmin;
                check = true;
            }

            if (check)
            {
                try
                {
                    lib.Members().Update(selected);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning");
                }
            }
            
        }
    }
}
