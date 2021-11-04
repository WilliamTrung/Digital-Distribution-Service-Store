using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interface
{
    public interface IProduct
    {
        public List<Product> GetProducts();
        public void Insert(Product product);
        public void Update(Product product);
        public void Delete(Product product);
        public List<Product> SearchByName(string search);
        public void SortByCategory(ref List<Product> list);
    }
}
