using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GaoKao.WebUI.Common;
using Wind.Framework.Utility;
using Wind.Framework.Web;
using Wind.Account.Contract;
using Wind.Framework.Contract;
using Wind.Web;
namespace GaoKao.WebUI.Areas.Account.Controllers
{
    public class AuthController : AdminControllerBase
    {
        [AuthorizeIgnore]
        public ActionResult Login(string msg="")
        {
            if (string.IsNullOrEmpty(msg)) {
                msg = "请输入你的帐号和密码";
            }
            ViewBag.Msg = msg;
            return View();
        }
        
        [HttpPost]
        [AuthorizeIgnore]
        public ActionResult Login(string username, string password, string verifycode)
        {
            if (!VerifyCodeHelper.CheckVerifyCode(verifycode, this.CookieContext.VerifyCodeGuid))
            {
                ModelState.AddModelError("error", "验证码错误");
                return View();
            }
            
            var loginInfo = this.AccountService.Login(username, password);

            if (loginInfo != null)
            {
                this.CookieContext.UserToken = loginInfo.LoginToken;
                this.CookieContext.UserName = loginInfo.LoginName;
                this.CookieContext.UserId = loginInfo.UserID;
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("error", "用户名或密码错误");
                return View();
            }
        }

        public ActionResult Logout()
        {
            this.AccountService.Logout(this.CookieContext.UserToken);
            this.CookieContext.UserToken = Guid.Empty;
            this.CookieContext.UserName = string.Empty;
            this.CookieContext.UserId = 0;
            return RedirectToAction("Login");
        }

        public ActionResult ModifyPwd()
        {
            var model = this.AccountService.GetUser(this.LoginInfo.UserID);
            return View(model);
        }

        [HttpPost]
        public ActionResult ModifyPwd(FormCollection collection)
        {
            var model = this.AccountService.GetUser(this.LoginInfo.UserID);
            this.TryUpdateModel<User>(model);

            try
            {
                this.AccountService.ModifyPwd(model);
            }
            catch (BusinessException e)
            {
                this.ModelState.AddModelError(e.Name, e.Message);
                return View(model);
            }

            return this.RefreshParent();
        }

        public ActionResult Index()
        {
            return View();
        }

        [AuthorizeIgnore]
        public ActionResult VerifyImage()
        {
            var s1 = new ValidateCode_Style4();
            string code = "6666";
            byte[] bytes = s1.CreateImage(out code);

            this.CookieContext.VerifyCode = code;

            return File(bytes, @"image/jpeg");

        }
        [AuthorizeIgnore]
        public ActionResult Register() {
            return View();
        }
        [HttpPost]
        [AuthorizeIgnore]
        public ActionResult Register(string username, string password) {
            var userInfo = this.AccountService.GetUserList().Where(a=>a.LoginName==username.Trim());

            if (userInfo == null || userInfo.Count()==0) {
                var account = new User() {  LoginName=username.Trim(), Password=Encrypt.MD5(password) };
                this.AccountService.SaveUser(account);

                return RedirectToAction("login", new {Msg="注册成功,请登陆" });
            }
            else {
                ModelState.AddModelError("error", "该账号已存在,请重新注册");
                return View();
            }
        }

    }
}
