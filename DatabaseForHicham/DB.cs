using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseForHicham
{
    public static class DB
    {
        private static Demo1Entities myDB = new Demo1Entities();

        public static IEnumerable<Product> GetProducts()
        {
            return myDB.Products.ToList();
        }
        public static IEnumerable<Customer> GetCusts()
        {
            return myDB.Customers.ToList();
        }

        public static Product GetProduct(int id)
        {
            return myDB.Products.Find(id);
        }

        public static Customer GetCustomer(int id)
        {
            return myDB.Customers.Find(id);
        }

        public static void DisplayProd()
        {
            var prods = DB.GetProducts();
            foreach (Product item in prods)
            {
                Console.WriteLine("\n Id : " + item.ProductId + " \n Desc : " + item.ProductDescription + " \n Upc : " + item.ProductUpc + "\n");
            }
        }
        public static void DisplayCust()
        {
            var cust = DB.GetCusts();
            foreach (Customer item in cust)
            {
                Console.WriteLine("\n Id : " + item.CustomerID + " \n First Name : " + item.CustomerFirstName + " \n Upc : " + item.CustomerLastName + "\n");
            }
        }

        public static void addProduct(String desc, String code)
        {
            Product p = new Product();
            p.ProductDescription = desc;
            p.ProductUpc = code;

            myDB.Products.Add(p);
            myDB.SaveChanges();
        }

        public static void addCustomer(String fname, String lname)
        {
            Customer cust = new Customer();
            cust.CustomerFirstName = fname;
            cust.CustomerLastName = lname;

            myDB.Customers.Add(cust);
            myDB.SaveChanges();
        }

        public static void updateProd(int id, String desc, string code)
        {

            Product p = GetProduct(id);
            p.ProductDescription = desc;
            p.ProductUpc = code;
            myDB.Entry(p).State = System.Data.Entity.EntityState.Modified;
            myDB.SaveChanges();
        }

        public static void updateCust(int id, String fname, String lname)
        {
            Customer c = GetCustomer(id);
            c.CustomerFirstName = fname;
            c.CustomerLastName = lname;

            myDB.Entry(c).State = System.Data.Entity.EntityState.Modified;
            myDB.SaveChanges();
        }

        public static void deleteProd(int id)
        {
            Product p = DB.GetProduct(id);

            myDB.Products.Remove(p);
            myDB.SaveChanges();
        }

        public static void deleteCust(int id)
        {
            Customer p = DB.GetCustomer(id);

            myDB.Customers.Remove(p);
            myDB.SaveChanges();
        }
    }
}


