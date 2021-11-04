using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interface
{
    public interface IOrder
    {
        public List<Order> GetOrders();
        public Order Insert(Order order);
        public Order Update(Order order);
        public void Delete(Order order);
        public void Close(Order order);
        public List<Order> GetOrdersByDate(DateTime start, DateTime end);
        public double TotalOf(Order order);
    }
}
