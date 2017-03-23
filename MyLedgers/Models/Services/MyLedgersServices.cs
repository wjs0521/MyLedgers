using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using MyLedgers.Models;
using MyLedgers.Models.ViewModels;
using System.Web.Mvc;

namespace MyLedgers.Models.Services
{
    public class MyLedgersService
    {
        private SkillTreeHomeworkEntities db = new SkillTreeHomeworkEntities();

        public List<Ledgers> GetLists()
        {
            List<Ledgers> datalist = new List<Ledgers>();
            foreach (var item in db.AccountBook)
            {
                Ledgers data = new Ledgers();
                if (item.Categoryyy == 0)
                {
                    data.Category = "支出";
                }
                //if (item.Categoryyy == 1)
                else
                {
                    data.Category = "收入";
                }
                data.Amount = item.Amounttt;
                data.PriceDate = item.Dateee;
                data.Remark = item.Remarkkk;
                datalist.Add(data);
            }

            return datalist;
        }

        public List<SelectListItem> CategoryLov()
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

            return CategoryList;
        }
    }
}