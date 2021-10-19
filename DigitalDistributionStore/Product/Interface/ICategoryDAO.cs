using DigitalDistributionStoreLibrary.DataAccess;
using Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.Repository
{
    public interface ICategoryDAO
    {
        public List<Category> GetCategories() => CategoryDAO.Instance.GetCatagories();
        public Boolean InsertCategory(Category category) => CategoryDAO.Instance.InsertCategory(category);
        public Boolean UpdateCategory(Category category) => CategoryDAO.Instance.UpdateCategory(category);
        public Boolean RemoveCategory(Category category) => CategoryDAO.Instance.UpdateCategory(category);
    }
}
