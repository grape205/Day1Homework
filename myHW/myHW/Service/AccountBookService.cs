using myHW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using myHW.Helpers;
namespace myHW.Service
{
    public class AccountBookService
    {
        private  SkillTreeHomeworkEntities _db;
        public AccountBookService()   //建構子
        {
            _db = new SkillTreeHomeworkEntities();
        }
       
        public IList<calculateViewModels> GetAccountBookDetail()
        {
            HtmlExtensions.EnumDisplayNameFor((CategoryyyType)Enum.GetValues(typeof(CategoryyyType)).GetValue(1));
            IList<calculateViewModels> model = _db.AccountBook.Select(x => x).OrderByDescending(x=>x.Dateee)
                         .ToList() // return int[]
                         .Select((x, index) => new calculateViewModels
                         {
                             ID = index + 1,
                             Money = x.Amounttt,
                             Type = HtmlExtensions.EnumDisplayNameFor((CategoryyyType)Enum.GetValues(typeof(CategoryyyType)).GetValue(x.Categoryyy)),
                             //Type = x.Categoryyy.ToString(),
                             CreateTime = x.Dateee,
                             Note = x.Remarkkk
                         }).ToList(); 

            return model;
        }
        public bool Calculate_Add(AccountBook _dt)
        {
            try
            {
                _dt.Id = Guid.NewGuid();
                _db.AccountBook.Add(_dt);
                _db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}