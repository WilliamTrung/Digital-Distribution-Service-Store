using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interface
{
    public interface IOrderDetail
    {
        public List<OrderDetail> GetOrderDetailsByOrder(Order order);
        public OrderDetail Generate(Product product, Order order, int quantity);
        public void Insert(OrderDetail detail);
        public void Update(OrderDetail detail);
        public void Remove(OrderDetail detail);
        
    }
}
