using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DependencyInjectorWeb.Controllers
{
    public class HomeController : Controller
    {
        private ILog log;
        private IHighScoreSaveService s;
        public HomeController(ILog log, IHighScoreSaveService s )
        {
            this.log = log;
            this.s = s;
        }
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
    }
}