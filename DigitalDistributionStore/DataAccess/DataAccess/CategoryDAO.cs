using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CategoryDAO
    {
        public static List<Category> GetCategories()
        {
            var list = new List<Category>();
            try
            {
                using (var context = new DBContext())
                {
                    list = context.Categories.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return list;
        }
        public static void Insert(Category category)
        {
            try
            {
                using (var context = new DBContext())
                {
                    var check = context.Categories.SingleOrDefault(c => c.CategoryName == category.CategoryName);
                    if (check == null)
                        {
                        context.Categories.Add(category);
                        context.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("This category has already existed!");
                    }
                }                   
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
            
        
        public static void Update(Category category)
        {
            try
            {
                using (var context = new DBContext())
                {
                    var check = context.Categories.SingleOrDefault(c => c.CategoryName == category.CategoryName);
                    if (check == null)
                    {
                        context.Entry<Category>(category).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                        context.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("This category has already existed!");
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void Delete(Category category)
        {
            try
            {
                using (var context = new DBContext())
                {
                    var check = context.Categories.SingleOrDefault(c => c.CategoryID == category.CategoryID);
                    if (check != null)
                    {
                        context.Categories.Remove(check);
                        context.SaveChanges();
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
