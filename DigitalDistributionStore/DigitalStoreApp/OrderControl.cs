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
        Member loginUser { get; set; }
        OrderRepository orderRepository = new OrderRepository();
        OrderDetailRepository orderDetailRepository = new OrderDetailRepository();
        Order order;
        public OrderControl(Member loginUser)
        {
            InitializeComponent();
            this.loginUser = loginUser;
            context = new ISystemHandler();
        }

        private void OrderControl_Load(object sender, EventArgs e)
        {
            btCheckOutOrder.Enabled = false;
            btSortByDate.Enabled = false;
            btSortbyTime.Enabled = false;
            if (loginUser != null)
            {
                var orderList= orderRepository.GetOrders();
                List<Order> orderListByMember = orderList.Where(p => p.MemberID == loginUser.MemberID && p.Status==false).ToList();
                LoadListOrder(orderListByMember);
                btSortByDate.Enabled = true;
                btSortbyTime.Enabled = true;
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
                             }).ToList();
            dgvOrder.DataSource = queryList;
            dgvOrder.Refresh();
        }
        private void dgvOrder_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOrder.SelectedRows.Count > 0)
            {
                int OrderId = Convert.ToInt32(dgvOrder.SelectedRows[0].Cells[0].Value.ToString());
                {
                    Order order = orderRepository.GetOrders().SingleOrDefault(p => p.OrderID == OrderId);
                    if (order != null)
                    {
                        var orderDetails = orderDetailRepository.GetOrderDetailsByOrder(order);
                        LoadListOrderDetails(orderDetails);
                        btCheckOutOrder.Enabled = true;
                        this.order = order;
                    }
                }
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
                                 ProductName= product.ProductName,
                                 Category= category.CategoryName,
                                 Price= orderDetail.UnitPrice,
                                 Quantity = orderDetail.Quantity,
                                 Total= orderDetail.Quantity*orderDetail.UnitPrice
                             }).ToList();
            dgvOrderDetail.DataSource = queryList;
            dgvOrderDetail.Refresh();
        }

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
    }
}
