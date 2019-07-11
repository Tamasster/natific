using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TinyWarehouse.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Inventory()
        {
            return View();
        }

        public ActionResult Receiving()
        {
            ViewBag.Message = "T B D";

            return View();
        }

        public ActionResult Shipping()
        {
            ViewBag.Message = "T B D";

            return View();
        }

        public ActionResult Statistics()
        {
            ViewBag.Message = "T B D";

            return View();
        }

        public ActionResult Parts()
        {
            ViewBag.Message = "T B D";

            return View();
        }
    }
}