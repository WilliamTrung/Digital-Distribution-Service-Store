using BusinessObject;
using DataAccess.Interface;
using DataAccess.Repository;
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
    public partial class frmBill : Form
    {
        ISystemHandler context;
        public Order order { get; set; }
        public Member mem { get; set; }
        public Member loginUser {get;set;}
        public frmBill()
        {
            InitializeComponent();
            context = new ISystemHandler();
        }
        private void frmBill_Load(object sender, EventArgs e)
        {
            if (order != null)
            {
                var orderDetails = context.OrderDetails().GetOrderDetailsByOrder(order);
                LoadListOrderDetails(orderDetails);
                lbOrderIDInfo.Text = order.OrderID.ToString();
                lbEmployeeIDInfo.Text = order.MemberID.ToString();
                lbDateInfo.Text = order.OrderDate.ToString();
                double total = context.Orders().TotalOf(order);
                lbTotalMoney.Text = total.ToString();
            }
        }

        public void LoadListOrderDetails(IEnumerable<OrderDetail> orderDetails)
        {
            var queryList = (from orderDetail in orderDetails
                             join product in context.Products().GetProducts()
                             on orderDetail.ProductID equals product.ProductID
                             join category in context.Categories().GetCategories()
                             on product.CategoryID equals category.CategoryID
                             select new
                             {
                                 ProductName = product.ProductName,
                                 Category = category.CategoryName,
                                 Price = orderDetail.UnitPrice,
                                 Quantity = orderDetail.Quantity,
                                 Total = orderDetail.Quantity * orderDetail.UnitPrice
                             }).ToList();
            dgvDetail.DataSource = queryList;
            dgvDetail.Refresh();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            try
            {
                if (loginUser.IsAdmin == true)
                {
                    Close();
                }
                else
                {
                    //MessageBox.Show("Bill extracted");
                    Close();
                }
            }
            catch
            {

            }  
        }
    }
}
