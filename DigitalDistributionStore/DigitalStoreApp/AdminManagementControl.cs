using BusinessObject;
using DataAccess.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DigitalStoreApp
{
    public partial class AdminManagementControl : UserControl
    {
        int control;
        Member loginUser;
        ISystemHandler lib;
        DBContext _context;
        public AdminManagementControl(Member loginUser)
        {
            InitializeComponent();
            this.loginUser = loginUser;
            lib = new ISystemHandler();
            _context = new DBContext();
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
        }
        private void LoadAllMembers(List<Member> members)
        {
            var query = (from member in members
                         select new
                         {
                             Name = member.MemberName,
                             Email = member.Email,
                             Password = member.Password,
                             Ban = member.Status,
                             Manager = member.IsAdmin
                         }).ToList();
            dgvDisplay.DataSource = query;
            dgvDisplay.ReadOnly = false;
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
                             Creator = member.MemberName
                         }).ToList();
            dgvDisplay.DataSource = query;
            dgvDisplay.ReadOnly = true;
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
                    frmMemberDetail.ShowDialog();
                    LoadAllMembers(lib.Members().GetMembers());
                    break;
            }
        }

        private void btDelete_Click(object sender, System.EventArgs e)
        {
            var selected_row = dgvDisplay.CurrentRow;
            if(selected_row != null)
            {
                var choice = MessageBox.Show("Are you sure to delete?", "Warning", MessageBoxButtons.YesNo);
                if(choice == DialogResult.Yes)
                {
                    int id = Int32.Parse(selected_row.Cells[0].ToString());
                    try
                    {
                        switch (control)
                        {
                            case 1:
                                var category = _context.Categories.Find(id);
                                lib.Categories().Delete(category);
                                break;
                            case 2:
                                var product = _context.Products.Find(id);
                                lib.Products().Delete(product);
                                break;
                            case 3:
                                var member = _context.Members.Find(id);
                                lib.Members().Delete(member);
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

        }
    }
}
