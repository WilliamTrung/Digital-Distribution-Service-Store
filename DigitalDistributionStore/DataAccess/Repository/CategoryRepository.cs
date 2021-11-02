using BusinessObject;
using DataAccess.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class CategoryRepository : ICategory
    {
        public void Delete(Category category) => CategoryDAO.Delete(category);

        public List<Category> GetCategories() => CategoryDAO.GetCategories();

        public void Insert(Category category) => CategoryDAO.Insert(category);

        public void Update(Category category) => CategoryDAO.Update(category);
    }
}
