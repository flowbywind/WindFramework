using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GaokaoWeb.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            
            using (var context =new  Models.GaoKaoContext()) {
                bool flag =  context.Database.CreateIfNotExists();
                Console.WriteLine(flag);
                var answer = new Model.Answer() { Analyze = "1", CourseID = 1 };
                context.Answer.Add(answer);
                context.SaveChanges();

                return Json(answer, JsonRequestBehavior.AllowGet);
            }
            //return RedirectToAction("Index", "Auth", new { Area="Account" });
        }

    }
}
