using myHW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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
            
            IList<calculateViewModels> model = _db.AccountBook.Select(x => x)
                         .ToList() // return int[]
                         .Select((x, index) => new calculateViewModels
                         {
                             ID = index + 1,
                             Money=x.Amounttt,
                             Type = x.Categoryyy % 2 == 0 ? "支出" : "收入",
                             CreateTime = x.Dateee,
                             Note = x.Remarkkk
                         }).ToList(); 

            return model;
        }


    }
}