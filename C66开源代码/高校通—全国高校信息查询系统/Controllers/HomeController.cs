using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace 高校通_全国高校信息查询系统.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MainPage()
        {
            return View("MainPage");
        }

        public ActionResult HomePage()
        {
            return View();
        }
    }
}