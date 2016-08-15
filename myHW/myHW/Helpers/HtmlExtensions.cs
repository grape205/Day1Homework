using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace myHW.Helpers
{
    public static class HtmlExtensions
    {
        /// <summary>
        /// 反查列舉DisplayName
        /// </summary>
        /// <param name="item">Enum object</param>
        /// <returns></returns>
        public static string EnumDisplayNameFor(this Enum item)
        {
            var type = item.GetType();
            var member = type.GetMember(item.ToString());
            DisplayAttribute displayname = (DisplayAttribute)member[0].GetCustomAttributes(typeof(DisplayAttribute), false).FirstOrDefault();

            if (displayname != null)
            {
                return  displayname.Name;
            }

            return  item.ToString();
        }
        /// <summary>
        /// set html class with 帳單狀態
        /// </summary>
        /// <param name="Categoryyy"></param>
        /// <returns></returns>
        public static string setColorCategoryyy(string Categoryyy)
        {
            if (Categoryyy == "支出")
            {
                return "Expense";
            }
            else 
            {
                return "Income";
            }

        }
    }
}