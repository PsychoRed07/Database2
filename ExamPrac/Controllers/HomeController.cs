using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Database2;

namespace ExamPrac.Controllers
{
    public class HomeController : Controller
    {
        DBManager DB = new DBManager();
        // GET: Home
        public ActionResult Index()
        {
            var cust = DB.GetProduct(1);

            return View(cust);
        }

    }
}