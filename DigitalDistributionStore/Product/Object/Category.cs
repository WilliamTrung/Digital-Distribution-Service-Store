using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    public class Category
    {
        public Category(int id, string categoryName)
        {
            this.categoryId = id;
            this.categoryName = categoryName;
        }
        public Category(string categoryName)
        {
            this.categoryName = categoryName;
        }
        public Category()
        {

        }
        
        public int categoryId { get; set; }
        public string categoryName { get; set; }
    }
}
