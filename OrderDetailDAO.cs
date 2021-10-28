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
    }
}
