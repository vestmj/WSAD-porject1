using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WSAD_project1.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// To create a user account for my application.
        /// </summary>
        /// <returns>View result for Create.</returns>
        public ActionResult Create()
        {
            return this.RedirectToAction("Login");
        }

        /// <summary>
        /// Login in to application.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            return Content("Hello " + username + ", Welcome to our application.");
        }
    }
}