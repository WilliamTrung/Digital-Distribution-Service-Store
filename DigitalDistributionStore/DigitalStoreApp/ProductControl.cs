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
        Member loginUser;
        ISystemHandler context;
        List<Product> products;
        Order order;
        public ProductControl(Member loginUser)
        {
            InitializeComponent();
            //this.loginUser = loginUser;

            loginUser = new DBContext().Members.SingleOrDefault(m => m.Email == "test@");
            products = new List<Product>();
            context = new ISystemHandler();
            //init order and save to db
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
        private void LoadCbCategories()
        {
            var cateList = context.Categories().GetCategories();
            cbCategory.DataSource = cateList;
            cbCategory.ValueMember = "CategoryName";
            cbCategory.DisplayMember = "CategoryName";
        }
        private void LoadOrderDetails()
        {
            var list_details = order.OrderDetails;
            
            dgvOrder.DataSource = list_details;

            dgvOrder.Refresh();
        }
        private void LoadProducts(string search)
        {
            products = context.Products().SearchByName(search);
            dgvProduct.DataSource = products;
            dgvProduct.Refresh();
        }
        private void btAddToOrder_Click(object sender, EventArgs e)
        {
            Product selected_product = (Product)dgvProduct.CurrentRow.DataBoundItem;
            //remake
            //order detail
            int quantity = 1;
            OrderDetail detail = context.OrderDetails().Generate(selected_product, order, quantity);
            context.OrderDetails().Insert(detail);
            order.OrderDetails.Add(detail);
            LoadOrderDetails();
        }

        private void btSaveOrder_Click(object sender, EventArgs e)
        {

        }

        private void ProductControl_Load(object sender, EventArgs e)
        {
            LoadProducts("");
            LoadCbCategories();
        }

        private void tbProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btSortByName_Click(object sender, EventArgs e)
        {

        }

        private void btSortByType_Click(object sender, EventArgs e)
        {
            products = context.Products().SortByCategory(products);
            dgvProduct.DataSource = products;
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            LoadProducts("");
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            string cate_name = cbCategory.SelectedItem.ToString();
            string pro_name = tbProductName.Text;

            var list = context.Products().SearchByName(pro_name);
            list = list.Where(p => p.Category.CategoryName == cate_name).ToList();
            dgvProduct.DataSource = list;
            dgvProduct.Refresh();
        }

        private void btRemoveFromOrder_Click(object sender, EventArgs e)
        {
            OrderDetail selected_detail = (OrderDetail)dgvOrder.CurrentRow.DataBoundItem;
            order.OrderDetails.Remove(selected_detail);
            LoadOrderDetails();
        }
    }
}
