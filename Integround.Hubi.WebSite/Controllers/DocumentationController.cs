using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Integround.Hubi.WebSite.Controllers
{
    public class DocumentationController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Hubi()
        {
            return View();
        }

        public ActionResult Components()
        {
            return View();
        }
    }
}