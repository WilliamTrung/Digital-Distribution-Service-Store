using BusinessObject;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OrderDetailDAO
    {
        public static List<OrderDetail> GetOrderDetailsByOrder(Order order)
        {
            var ListOrderDetails = new List<OrderDetail>();
            try
            {
                using (var context = new DBContext())
                {
                    ListOrderDetails = context.OrderDetails.Include(d => d.Order).Where(d => d.OrderID == order.OrderID).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return ListOrderDetails;
        }

        public static void Remove(OrderDetail detail)
        {
            try
            {
                using (var context = new DBContext())
                {
                    if(detail.Order.Status == false)
                    {
                        throw new Exception("This order has ended! Cannot be removed!");
                    }
                    else
                    {
                        var check = context.OrderDetails.SingleOrDefault(d => d.OrderID == detail.OrderID);
                        if (check != null)
                        {
                            context.Remove(detail);
                            context.SaveChanges();
                        }
                        else
                        {
                            throw new Exception("This detail is not found!");
                        }
                    }                  
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void Update(OrderDetail detail)
        {
            try
            {
                if (detail.Order.Status == false)
                {
                    throw new Exception("This order has ended! Cannot be updated!");
                } 
                else
                {
                    using (var context = new DBContext())
                    {
                        context.Entry<OrderDetail>(detail).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                        context.SaveChanges();
                    }
                }               
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static OrderDetail GenerateOrderDetail(Product product, Order order, int quantity)
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
        public static void Insert(OrderDetail detail)
        {
            try
            {
                using (var context = new DBContext())
                {
                    var check = context.OrderDetails.SingleOrDefault(d => d.OrderID == detail.OrderID && d.ProductID == detail.ProductID);
                    if (check == null)
                    {
                        var add = new OrderDetail()
                        {
                            OrderID = detail.OrderID,
                            ProductID = detail.ProductID,
                            Quantity = detail.Quantity,
                            UnitPrice = detail.UnitPrice
                        };
                        context.Add(add);                       
                    }
                    else
                    {
                        context.Entry<OrderDetail>(detail).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    }
                    context.SaveChanges();
                }
            }
            catch 
            {
                throw;
            }
        }

    }
}
