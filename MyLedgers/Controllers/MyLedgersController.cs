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
            List<SelectListItem> CategoryList = new List<SelectListItem>();

            CategoryList.Add(new SelectListItem()
            {
                Text = "請選擇",
                Value = "請選擇",
                Selected = true
            });

            CategoryList.Add(new SelectListItem()
            {
                Text = "支出",
                Value = "支出",
                Selected = false
            });

            CategoryList.Add(new SelectListItem()
            {
                Text = "收入",
                Value = "收入",
                Selected = false
            });

            ViewBag.Category = CategoryList;

            return View();
        }
    }
}