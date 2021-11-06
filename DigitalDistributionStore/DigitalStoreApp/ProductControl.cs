using BusinessObject;
using DataAccess.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalStoreApp
{
    public partial class ProductControl : UserControl
    {
        public Member loginUser;
        ISystemHandler context;
        List<Product> products;
        Order order;
        DBContext db;
        Boolean bug = false;

        private class Detail {
            public int ProductID { get; set; }
            public string Name { get; set; }
            public string Category { get; set; }
            public double Price { get; set; }
            public int Quantity { get; set; }
        }
        private Order CheckLastOrder(Member loginUser)
        {
            //Reuse the last order that not being closed!
            try
            {
                var order = db.Orders.SingleOrDefault(o => o.MemberID == loginUser.MemberID && o.Status == true);
                return order;
            }
            catch
            {

            }
            return null;
        }
        public ProductControl(Member loginUser)
        {
            InitializeComponent();
            context = new ISystemHandler();
            db = new DBContext();
            this.loginUser = loginUser;
            order = CheckLastOrder(loginUser);
            if(order == null)
            {
                order = new Order()
                {
                    Member = loginUser,
                    MemberID = loginUser.MemberID,
                    OrderDate = DateTime.Now,
                    Status = true,
                    OrderDetails = new List<OrderDetail>()
                };
                order = context.Orders().Insert(order);
            }            
            products = new List<Product>();                      
        }
        private void LoadCbCategories()
        {
            var cateList = context.Categories().GetCategories();
            cbCategory.DataSource = cateList;
            cbCategory.ValueMember = "CategoryName";
            cbCategory.DisplayMember = "CategoryName";
        }
        private OrderDetail DetailToOrderDetail(Detail d)
        {
            return new OrderDetail
            {
                ProductID = d.ProductID,
                UnitPrice = d.Price,
                Quantity = d.Quantity,
                OrderID = order.OrderID,
                Order = order
            };
        }
        private void LoadOrderDetails(List<OrderDetail> details)
        {
            
            var queryList = (from detail in details
                             join product in context.Products().GetProducts()
                             on detail.ProductID equals product.ProductID
                             select new Detail
                             {
                                 ProductID = product.ProductID,
                                 Name =  product.ProductName,
                                 Category =  product.Category.CategoryName,
                                 Price = detail.UnitPrice,
                                 Quantity =  detail.Quantity
                             }).ToList();
            foreach(var detail in queryList)
            {
                int pro = detail.ProductID;
                int quantity = detail.Quantity;
            }
            dgvOrder.DataSource = null;
            dgvOrder.DataSource = queryList;
            dgvOrder.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvOrder.Columns[0].Visible = false;
            dgvOrder.Columns[1].ReadOnly = true;
            dgvOrder.Columns[2].ReadOnly = true;
            dgvOrder.Columns[3].ReadOnly = true;
            dgvOrder.Columns[4].ReadOnly = false;
            
            dgvOrder.Refresh();
        }
        private void LoadProducts(List<Product> products)
        {
            //context.Products().SearchByName(search);
            var queryList = (from product in products
                             join category in context.Categories().GetCategories()
                             on product.CategoryID equals category.CategoryID
                             select new
                             {
                                 product.ProductID,
                                 Name = product.ProductName,
                                 Price = product.UnitPrice,
                                 InStock = product.UnitsInStock,
                                 CategoryName = category.CategoryName
                             }).ToList();
            dgvProduct.DataSource = queryList;
            dgvProduct.Columns[0].Visible = false;
            dgvProduct.Refresh();
        }
        private void btAddToOrder_Click(object sender, EventArgs e)
        {
            //Product selected_product = (Product)dgvProduct.CurrentRow.DataBoundItem;
            var selected_row = dgvProduct.CurrentRow;
            if(selected_row != null)
            {
                Product selected = new Product()
                {
                    ProductID = Int32.Parse(selected_row.Cells[0].Value.ToString()),
                    ProductName = selected_row.Cells[1].Value.ToString(),
                    UnitPrice = Double.Parse(selected_row.Cells[2].Value.ToString())
                };
                int quantity = 1;

                OrderDetail detail = context.OrderDetails().Generate(selected, order, quantity);
                context.OrderDetails().Insert(detail);              

                LoadOrderDetails(context.OrderDetails().GetOrderDetailsByOrder(order));
            }
            else
            {
                MessageBox.Show("No product is chosen!","Notification");
            }           
        }

        private void btSaveOrder_Click(object sender, EventArgs e)
        {
            var details = context.OrderDetails().GetOrderDetailsByOrder(order);
            if (details.Count > 0)
            {
                var message_answer = MessageBox.Show("Extract bill?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (message_answer == DialogResult.Yes)
                {
                    context.Orders().Close(order);
                    //extract bill code here
                    frmBill frmBill = new frmBill
                    {
                        loginUser = this.loginUser,
                        mem = this.loginUser,
                        order = db.Orders.Find(order.OrderID)
                    };
                    frmBill.Show();
                    try
                    {
                        //init new order and save to db
                        order = new Order()
                        {
                            Member = loginUser,
                            MemberID = loginUser.MemberID,
                            OrderDate = DateTime.Now,
                            Status = true,
                            OrderDetails = new List<OrderDetail>()
                        };
                        order = context.Orders().Insert(order);
                        products = context.Products().GetProducts();
                        LoadProducts(products);
                        LoadCbCategories();
                        LoadOrderDetails(context.OrderDetails().GetOrderDetailsByOrder(order));
                    }
                    catch
                    {

                    }
                    
                }
            }   
            else
            {
                MessageBox.Show("No detail to extract bill!","Notification");
            }
        }

        private void ProductControl_Load(object sender, EventArgs e)
        {
            //init order and save to db
            loginUser = order.Member;
            
            products = context.Products().GetProducts();
            LoadProducts(products);
            LoadOrderDetails(context.OrderDetails().GetOrderDetailsByOrder(order));
            LoadCbCategories();
        }

        private void tbProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btSortByName_Click(object sender, EventArgs e)
        {
            products = products.OrderBy(p => p.ProductName).ToList();
            LoadProducts(products);
        }

        private void btSortByType_Click(object sender, EventArgs e)
        {
            products = context.Products().SortByCategory(products);
            LoadProducts(products);
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            products = context.Products().GetProducts();
            LoadProducts(products);
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            Category cate_name = (Category)cbCategory.SelectedItem;
            string pro_name = tbProductName.Text;

            products = context.Products().SearchByName(pro_name);
            products = products.Where(p => p.Category.CategoryName == cate_name.CategoryName).ToList();
            LoadProducts(products);
        }

        private void btRemoveFromOrder_Click(object sender, EventArgs e)
        {
            var selected_row = dgvOrder.CurrentRow;
            if(selected_row != null)
            {
                var detail = (Detail)selected_row.DataBoundItem;
                var orderDetail = DetailToOrderDetail(detail);
                context.OrderDetails().Remove(orderDetail);
                LoadOrderDetails(context.OrderDetails().GetOrderDetailsByOrder(order));
            }
            else
            {
                MessageBox.Show("No record is chosen!", "Notification");
            }                                
        }

        private void dgvOrder_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

        }

        private void dgvOrder_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Wrong format for Quantity!","Error");
        }

        

        private void btResetOrder_Click(object sender, EventArgs e)
        {
            var details = context.OrderDetails().GetOrderDetailsByOrder(order);
            if (details.Count > 0)
            {
                var message_answer = MessageBox.Show("Are you sure resetting this order?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (message_answer == DialogResult.Yes)
                {
                    context.OrderDetails().RemoveAll(order);
                    dgvOrder.DataSource = null;
                    dgvOrder.Refresh();
                }
            }
            else
            {
                MessageBox.Show("No detail to extract bill!", "Notification");
            }
        }

        private void dgvOrder_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvOrder.CurrentRow;
            
            if (row != null)
            {
                try
                {
                    Detail selected = (Detail)dgvOrder.CurrentRow.DataBoundItem;

                    int quantity = selected.Quantity;
                    int productID = selected.ProductID;

                    int instock = db.Products.Find(productID).UnitsInStock;
                    OrderDetail detail = db.OrderDetails.SingleOrDefault(d => d.OrderID == order.OrderID && d.ProductID == productID);
                    if (detail != null)
                    {
                        if (detail.Quantity == quantity)
                        {
                            //
                        }
                        else
                        {
                            if (quantity > instock)
                            {
                                ///////////////////
                                if (bug)
                                {
                                    bug = !bug;
                                    return;
                                }
                                bug = !bug;
                                //////////////////
                                string message;
                                if (instock >= 2)
                                {
                                    message = "\nThere are " + instock + " available!";
                                }
                                else
                                {
                                    message = "\nThere is " + instock + " available!";
                                }
                                MessageBox.Show("Maximum quantity reached!" + message, "Notification");
                                selected.Quantity = instock;
                            }
                            detail.Order = order;
                            detail.Quantity = selected.Quantity;
                            context.OrderDetails().Update(detail);
                            LoadOrderDetails(context.OrderDetails().GetOrderDetailsByOrder(order));
                        }
                    }
                }
                catch (Exception ex)
                {
                    string temp = ex.Message;
                    //MessageBox.Show("No record is chosen!", "Notification");
                }

            }
        }

        private void dgvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
