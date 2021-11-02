using BusinessObject;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OrderDAO
    {
        public static List<Order> GetOrders()
        {
            var ListOrder = new List<Order>();
            try
            {
                using (var context = new DBContext())
                {
                    ListOrder = context.Orders.OrderBy(o => o.OrderDate).Include(o => o.Member).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return ListOrder;
        }
        public static void Insert(Order order)
        {
            try
            {
                using (var context = new DBContext())
                {
                    context.Add(order);
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void Remove(Order order)
        {
            try
            {
                using (var context = new DBContext())
                {
                    var check = context.Orders.SingleOrDefault(o => o.OrderID == order.OrderID);
                    //status == true  => order can still be updated
                    if(check.Status == true)
                    {
                        context.Remove(order);
                        context.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("This order has already closed!");
                    }            
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void Update(Order order)
        {
            try
            {
                using (var context = new DBContext())
                {
                    var check = context.Orders.SingleOrDefault(o => o.OrderID == order.OrderID);
                    //status == true  => order can still be updated
                    if (check.Status == true)
                    {
                        context.Entry<Order>(order).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                        context.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("This order has already closed!");
                    }
                    
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void Close(Order order)
        {
            try
            {
                using (var context = new DBContext())
                {
                    var check = context.Orders.SingleOrDefault(o => o.OrderID == order.OrderID);
                    //status == true  => order can still be updated
                    if (check.Status == true)
                    {
                        order.Status = false;
                        context.Entry<Order>(order).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                        context.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("This order has already closed!");
                    }

                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static double TotalOf(Order order)
        {
            double result = 0;
            try
            {
                using (var context = new DBContext())
                {
                    var list_detail = context.OrderDetails.Where(d => d.OrderID == order.OrderID).ToList();
                    if(list_detail.Count > 0)
                    {
                        foreach (var detail in list_detail)
                        {
                            result += detail.UnitPrice * detail.Quantity;
                        }
                    }
                    else
                    {
                        throw new Exception("This order has no detail!");
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return result;
        }
        public static List<Order> GetOrdersByDate(DateTime start, DateTime end)
        {
            List<Order> list = new List<Order>();
            try
            {
                using (var context = new DBContext())
                {
                    list = context.Orders.Where(order => order.OrderDate >= start && order.OrderDate <= end).ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return list;
        }
    }
}
