using BusinessObject;
using DataAccess.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderDetailRepository : IOrderDetail
    {
        public OrderDetail Generate(Product product, Order order, int quantity)
        => OrderDetailDAO.GenerateOrderDetail(product, order, quantity);

        public List<OrderDetail> GetOrderDetailsByOrder(Order order)
        => OrderDetailDAO.GetOrderDetailsByOrder(order);

        public void Insert(OrderDetail detail)
        => OrderDetailDAO.Insert(detail);

        public void Remove(OrderDetail detail)
        => OrderDetailDAO.Remove(detail);

        public void RemoveAll(Order order)
        => OrderDetailDAO.RemoveAll(order);

        public void Update(OrderDetail detail)
        => OrderDetailDAO.Update(detail);
    }
}
