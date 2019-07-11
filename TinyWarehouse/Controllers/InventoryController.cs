using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TinyWarehouse.Models;
using TinyWarehouse.Repositories;

namespace TinyWarehouse.Controllers
{
    public class InventoryController : Controller
    {
        private readonly DataRepository db;

        public InventoryController()
        {
            db = new DataRepository();
        }

        // GET: Inventory
        public ActionResult FullInventory()
        {
            return Json(db.GetFullInventory(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetParts()
        {
            return Json(db.GetParts(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Statistics()
        {
            StatisticsDto st = new StatisticsDto
            {
                HasMost = db.HasMost(),
                PriceSum = db.PriceSum(),
                Weightest = db.Weightest(),
                WeightSum = db.WeightSum()
            };

            return Json(st, JsonRequestBehavior.AllowGet);
        }
    }
}