using AspMVCVuePost.Lib.Utils;
using AspMVCVuePost.Repository.Entities;
using AspMVCVuePost.Service;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspMVCVuePost.App.Controllers
{
    public class LoginController : Controller
    {
        public IAccountService AccountService { get; set; }
        public LoginController(
            IAccountService accountService 
            )
        {
            AccountService = accountService;
        }

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SubmitLogin(string email, string password)
        {
            var test = email;
            return Json(JsonResponseResult.CreateError("Success login", 
                Url.Action("index","home")), 
                JsonRequestBehavior.AllowGet);
        }
    }
}