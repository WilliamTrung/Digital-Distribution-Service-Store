using BusinessObject;
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
        public Member logInUser { get; set; }
        OrderRepository orderRepository = new OrderRepository();
        OrderDetailRepository orderDetailRepository = new OrderDetailRepository();
        public OrderControl()
        {
            InitializeComponent();
        }

        private void OrderControl_Load(object sender, EventArgs e)
        {
            btCheckOutOrder.Enabled = false;
            btSortByDate.Enabled = false;
            btSortbyTime.Enabled = false;
            if (logInUser != null)
            {
                var orderList= orderRepository.GetOrders();
                List<Order> orderListByMember = orderList.Where(p => p.MemberID == logInUser.MemberID).ToList();
                dgvOrder.DataSource = orderListByMember;
                btCheckOutOrder.Enabled = true;
                btSortByDate.Enabled = true;
                btSortbyTime.Enabled = true;
            }
        }

        private void dgvOrder_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOrder.SelectedRows.Count > 0)
            {
                int OrderId = Convert.ToInt32(dgvOrder.SelectedRows[0].Cells["OrderId"].Value.ToString());
                {
                    Order order = orderRepository.GetOrders().SingleOrDefault(p => p.OrderID == OrderId);
                    if (order != null)
                    {
                        var orderDetails = orderDetailRepository.GetOrderDetailsByOrder(order);
                        dgvOrderDetail.DataSource = orderDetails;
                    }
                }
            }
        }

        private void btCheckOutOrder_Click(object sender, EventArgs e)
        {

        }
    }
}
