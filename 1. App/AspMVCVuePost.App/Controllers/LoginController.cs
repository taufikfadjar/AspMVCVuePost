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
            var hello = new User();
 
           
            return View();
        }
    }
}