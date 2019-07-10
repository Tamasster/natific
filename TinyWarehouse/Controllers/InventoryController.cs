using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
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
    }
}