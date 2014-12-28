using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GaoKao.WebUI.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return  RedirectToAction("Index", "Auth", new { Area="Account"});
            using (var context = new Models.GaoKaoContext()) {
                var model = new Model.UserInfo() { AnswerCount=1, EquimentId="test", HeadUrl="", Score=50 };
                context.UserInfo.Add(model);
                context.SaveChanges();
               var answer = context.UserInfo.ToList();
               return Json(answer, JsonRequestBehavior.AllowGet);
            }
            ViewBag.Message = "修改此模板以快速启动你的 ASP.NET MVC 应用程序。";
            return View();
        }

        public ActionResult About() {
            ViewBag.Message = "你的应用程序说明页。";

            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "你的联系方式页。";

            return View();
        }
    }
}
