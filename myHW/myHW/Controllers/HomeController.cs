using myHW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace myHW.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult calculate()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [ChildActionOnly]
        public ActionResult calculate_Detail()
        {
            var model = new List<calculateViewModels>();
            model.Add(new calculateViewModels()
            {
                ID=1,
                Type="收入",
                Money=100,
                CreateTime=DateTime.Now,
                Note="備註一"
            });

            model.Add(new calculateViewModels()
            {
                ID = 2,
                Type = "支出",
                Money = 500,
                CreateTime = DateTime.Now,
                Note = "備註一"
            });

            model.Add(new calculateViewModels()
            {
                ID = 1,
                Type = "收入",
                Money = 600,
                CreateTime = DateTime.Now,
                Note = "備註一"
            });

            model.Add(new calculateViewModels()
            {
                ID = 1,
                Type = "收入",
                Money = 100,
                CreateTime = DateTime.Now,
                Note = "備註一"
            });
            
            ViewBag.Message = "Your contact page.";

            return View(model);
        }
    }
}