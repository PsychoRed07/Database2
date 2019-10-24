using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseForHicham;

namespace Database2
{
    public class DBManager
    {
        static void Main(string[] args)
        {
            //main
            var prods = DB.GetProducts();
            DB.addProduct("BEAR", "12345");
            DB.updateProd(1, "OLED", "10010");
            DB.DisplayProd();
        }

    }
}
