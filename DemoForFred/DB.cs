using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoForFred
{
    
    public static class DB
    {
        private static Demo1Entities myDB = new Demo1Entities();

        public static IEnumerable<Product> Getproducts() {
            return myDB.Products.ToList();
        }

        public static IEnumerable<Product> GetProductById(int id) {
            return myDB.Products.Find(id);
        }
        public static Product GetProduct(int id) {
            return myDB.Products.Find(id);
        }
    }
}
