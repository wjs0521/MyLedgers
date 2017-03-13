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
            //List<Ledgers> datalist = new List<Ledgers>();
            //Ledgers data1 = new Ledgers();
            //data1.Category = "支出";
            //data1.Amount = 300;
            //data1.PriceDate = DateTime.Parse("2016-01-01"); ;
            //data1.Remark = "Test1";
            //datalist.Add(data1);
            //Ledgers data2 = new Ledgers();
            //data2.Category = "支出";
            //data2.Amount = 16000;
            //data2.PriceDate = DateTime.Parse("2016-01-02");
            //data2.Remark = "Test2";
            //datalist.Add(data2);
            //Ledgers data3 = new Ledgers();
            //data3.Category = "支出";
            //data3.Amount = 8000;
            //data3.PriceDate = DateTime.Parse("2016-01-03");
            //data3.Remark = "Test3";
            //datalist.Add(data3);

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