using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MyLedgers.Models.ViewModels
{
    public class Ledgers
    {
        [Display(Name = "類別")]
        public string Category { get; set; }
        [Display(Name = "金額")]
        [DisplayFormat(DataFormatString = "{0:N0}")]
        public int Amount { get; set; }
        [Display(Name = "日期")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime PriceDate { get; set; }
        [Display(Name = "備註")]
        public string Remark { get; set; }
    }
}