using BusinessObject;
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
                    ListOrder = context.Orders.ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return ListOrder;
        }
        public static void AddNew(Order order)
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
                    context.Remove(order);
                    context.SaveChanges();
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
                    context.Entry<Order>(order).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
