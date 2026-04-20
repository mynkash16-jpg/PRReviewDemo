using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PRReviewDemo.Controllers
{
	/// <summary>
	/// Default home controller for the application. This controller contains actions for the home page, about page, and contact page.
	/// </summary>
	public class HomeController : Controller
    {
	/// This is not proper summery
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to the home page!";
			return View();
        }
// This is about action method
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
			int i = 0;
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
