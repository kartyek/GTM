using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your About description page.";

            return View();
        }
        public ActionResult RESTAURANTS()
        {
            ViewBag.Message = "Your RESTAURANTS description page.";

            return View();
        }
        public ActionResult BANQUET()
        {
            ViewBag.Message = "Your BANQUET description page.";

            return View();
        }
        public ActionResult FACILITIES()
        {
            ViewBag.Message = "Your FACILITIES description page.";

            return View();
        }
        public ActionResult SPORTS()
        {
            ViewBag.Message = "Your SPORTS description page.";

            return View();
        }
        public ActionResult MEMBERS()
        {
            ViewBag.Message = "Your MEMBERS description page.";

            return View();
        }

         public ActionResult EVENTS()
        {
            ViewBag.Message = "Your EVENTS description page.";

            return View();
        }
         public ActionResult AFFILIATES()
        {
            ViewBag.Message = "Your AFFILIATES description page.";

            return View();
        }
                    
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}