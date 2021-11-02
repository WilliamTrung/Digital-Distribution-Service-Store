using BusinessObject;
using DataAccess.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProductRepository : IProduct
    {
        public void Delete(Product product) => ProductDAO.Delete(product);

        public List<Product> GetProducts() => ProductDAO.GetProducts();

        public void Insert(Product product) => ProductDAO.Insert(product);

        public List<Product> SearchByName(string search) => ProductDAO.SearchByName(search);

        public void Update(Product product) => ProductDAO.Update(product);
    }
}
