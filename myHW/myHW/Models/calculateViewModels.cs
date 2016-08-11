using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace myHW.Models
{
    public  class calculateViewModels
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public int Money { get; set; }
        public DateTime CreateTime { get; set; }
        public string Note { get; set; }
    }

    public enum CategoryyyType
    {
        [Description("收入")]
        Income= 0,
        [Description("支出")]
        Expense = 1,
    }

}