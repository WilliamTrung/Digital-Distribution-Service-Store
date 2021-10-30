using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProductDAO
    {
        public static List<Product> GetProducts()
        {
            var listProducts = new List<Product>();
            try
            {
                using (var context = new DBContext())
                {
                    listProducts = context.Products.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listProducts;
        }

        public static void Insert(Product product)
        {
            try
            {
                using (var context = new DBContext())
                {
                    var check = context.Products.SingleOrDefault(p => p.ProductName == product.ProductName);
                    if (check == null)
                    {
                        context.Products.Add(product);
                        context.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("This product has already existed!");
                    }
                    
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static void Update(Product product)
        {
            try
            {
                using (var context = new DBContext())
                {
                    var check = context.Products.SingleOrDefault(p => p.ProductName == product.ProductName);
                    if (check == null)
                    {
                        context.Entry<Product>(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                        context.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("This product has already existed!");
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static void Delete(Product product)
        {
            try
            {
                using (var context = new DBContext())
                {
                    var check = context.Products.SingleOrDefault(c => c.ProductID == product.ProductID);
                    if(check != null)
                    {
                        context.Products.Remove(check);
                        context.SaveChanges();
                    }                    
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static List<Product> SearchByName(string search)
        {
            List<Product> list = null;
            try
            {

                using (var context = new DBContext())
                {
                    list = context.Products.Where(product => product.ProductName.Contains(search)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }
    }
}
