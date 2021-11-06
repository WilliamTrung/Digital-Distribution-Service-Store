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
    public partial class OrderControl : UserControl
    {
        ISystemHandler context;
        DBContext db;
        public Member loginUser { get; set; }
        Order order;
        public OrderControl()
        {
            InitializeComponent();
            //this.loginUser = loginUser;
            context = new ISystemHandler();
            db = new DBContext();
        }

        private void OrderControl_Load(object sender, EventArgs e)
        {
            btCheckOutOrder.Enabled = false;
            btReload.Enabled = false;
            if (loginUser != null)
            {
                List<Order> orderListByMember = db.Orders.Where(o => o.MemberID == loginUser.MemberID && o.Status==false).ToList();
                LoadListOrder(orderListByMember);
                btReload.Enabled = true;
            }
        }
        public void LoadListOrder(IEnumerable<Order> orders)
        {
            var queryList = (from order in orders
                             join member in context.Members().GetMembers()
                             on order.MemberID equals member.MemberID
                             select new
                             {
                                 order.OrderID,
                                 Name = member.MemberName,
                                 Date = order.OrderDate
                             }).OrderBy(o => o.Date).ToList();
            dgvOrder.DataSource = queryList;
            dgvOrder.Refresh();
        }
        private void dgvOrder_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOrder.SelectedRows.Count > 0)
            {
                int OrderId = Convert.ToInt32(dgvOrder.SelectedRows[0].Cells[0].Value.ToString());
                {
                    Order order = context.Orders().GetOrders().SingleOrDefault(p => p.OrderID == OrderId);
                    if (order != null)
                    {
                        var orderDetails = context.OrderDetails().GetOrderDetailsByOrder(order);
                        //LoadListOrderDetails(orderDetails);
                        btCheckOutOrder.Enabled = true;
                        this.order = order;
                    }
                }
            }
        }
        /*
        public void LoadListOrderDetails(IEnumerable<OrderDetail> orderDetails)
        {
            var queryList = (from orderDetail in orderDetails
                             join product in context.Products().GetProducts()
                             on orderDetail.ProductID equals product.ProductID
                             join category in context.Categories().GetCategories()
                             on product.CategoryID equals category.CategoryID
                             select new
                             {
                                 ProductName= product.ProductName,
                                 Category= category.CategoryName,
                                 Price= orderDetail.UnitPrice,
                                 Quantity = orderDetail.Quantity,
                                 Total= orderDetail.Quantity*orderDetail.UnitPrice
                             }).ToList();
            dgvOrderDetail.DataSource = queryList;
            dgvOrderDetail.Refresh();
        }
        */
        private void btCheckOutOrder_Click(object sender, EventArgs e)
        {
            if (order != null)
            {
                frmBill frmBill = new frmBill {
                    mem=this.loginUser,
                    order=this.order
                };
                frmBill.Show();
            }
        }


        private void btReload_Click(object sender, EventArgs e)
        {
            List<Order> orderListByMember = db.Orders.Where(o => o.MemberID == loginUser.MemberID && o.Status == false).ToList();
            LoadListOrder(orderListByMember);
        }
    }
}
