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
       /// <summary>
       /// 下拉選單
       /// </summary>
       /// <param name="helper"></param>
       /// <param name="name"></param>
       /// <param name="type"></param>
       /// <param name="OptionString"></param>
       /// <param name="htmlattr"></param>
       /// <returns></returns>
        public static MvcHtmlString DropDownListEnum(this HtmlHelper helper, string name, Type type,string OptionString,object htmlattr)
        {
            if (!type.IsEnum) throw new ArgumentException("Type is not an enum.");
            var enums = new List<SelectListItem>();
            foreach (int value in Enum.GetValues(type))
            {
                string displayName = Enum.GetName(type, value);
                var label = type.GetField(Enum.GetName(type, value)).GetCustomAttributes(typeof(DisplayAttribute), false).Cast<DisplayAttribute>().FirstOrDefault();

                if (label != null)
                    displayName = label.Name;

                enums.Add(new SelectListItem { Value = value.ToString(), Text = displayName });
            }
            return System.Web.Mvc.Html.SelectExtensions.DropDownList(helper, name,enums, OptionString, htmlattr);
        }
    }
}