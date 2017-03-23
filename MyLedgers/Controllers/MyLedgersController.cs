using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MyLedgers.Models.ViewModels;
using MyLedgers.Models.Services;

namespace MyLedgers.Controllers
{
    public class MyLedgersController : Controller
    {
        MyLedgersService service = new MyLedgersService();

        // GET: MyLedgers
        public ActionResult Index()
        {
            var datalist = service.GetLists();

            return View(datalist);
        }

        public ActionResult CreateLedger()
        {
            var categorylist = service.CategoryLov();
            ViewBag.Category = categorylist;

            return View();
        }
    }
}