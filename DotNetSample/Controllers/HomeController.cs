using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DotNetSample.Controllers
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

        [HttpPost]
        public JsonResult SignIn(UserInfo userInfo)
        {
            try
            {
                //處理註冊邏輯
            }catch(Exception ex)
            {
                //例外處理
            }
            return Json(new { status=200 },JsonRequestBehavior.AllowGet);
        }

        public class UserInfo
        {
            public string Account { get; set; }

            public string Password { get; set; }
        }
    }
}