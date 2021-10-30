using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OrderDetailDAO
    {
        public static List<OrderDetail> GetOrderDetails()
        {
            var ListOrderDetails = new List<OrderDetail>();
            try
            {
                using (var context = new DBContext())
                {
                    ListOrderDetails = context.OrderDetails.ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return ListOrderDetails;
        }
        public static void AddNew(OrderDetail orderDetail)
        {
            try
            {
                using (var context = new DBContext())
                {
                    context.Add(orderDetail);
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void Remove(OrderDetail orderDetail)
        {
            try
            {
                using (var context = new DBContext())
                {
                    context.Remove(orderDetail);
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void Update(OrderDetail orderDetail)
        {
            try
            {
                using (var context = new DBContext())
                {
                    context.Entry<OrderDetail>(orderDetail).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static List<OrderDetail> GetOrderDetailsByOrder(Order order)
        {
            List<OrderDetail> list = new List<OrderDetail>();
            try
            {
                using (var context = new DBContext())
                {
                    list = context.OrderDetails.Where(order_detail => order_detail.OrderID == order.OrderID).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }
        private static OrderDetail GenerateOrderDetail(Product product, Order order, int quantity)
        {
            OrderDetail detail = new OrderDetail()
            {
                Order = order,
                OrderID = order.OrderID,
                Product = product,
                ProductID = product.ProductID,
                Quantity = quantity,
                UnitPrice = product.UnitPrice
            };
            return detail;
        }
        public static void InsertOrderDetail(Product product, Order order, int quantity)
        {
            try
            {
                OrderDetail detail = GenerateOrderDetail(product, order, quantity);
                using (var context = new DBContext())
                {
                    context.Add(detail);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
