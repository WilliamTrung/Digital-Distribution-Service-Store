using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interface
{
    public interface ICategory
    {
        public List<Category> GetCategories();
        public void Insert(Category category);
        public void Update(Category category);
        public void Delete(Category category);

    }
}
