using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using MyLedgers.Models;
using MyLedgers.Models.ViewModels;

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
                if (item.Categoryyy == 1)
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
    }
}