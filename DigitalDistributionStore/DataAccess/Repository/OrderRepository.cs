using BusinessObject;
using DataAccess.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderRepository : IOrder
    {
        public void Close(Order order)
        => OrderDAO.Close(order);

        public void Delete(Order order)
        => OrderDAO.Remove(order);

        public List<Order> GetOrders()
        => OrderDAO.GetOrders();

        public List<Order> GetOrdersByDate(DateTime start, DateTime end)
        => OrderDAO.GetOrdersByDate(start, end);

        public void Insert(Order order)
        => OrderDAO.Insert(order);

        public double TotalOf(Order order)
        => OrderDAO.TotalOf(order);

        public void Update(Order order)
        => OrderDAO.Update(order);
    }
}
