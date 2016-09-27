using System.Net;
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
            using (var client = new WebClient())
            {
                ViewBag.Content = client.DownloadString("https://igwebprodcontent.blob.core.windows.net/integround-hubi-web/hubi-documentation.xml");
            }

            return View();
        }

        public ActionResult Components()
        {
            using (var client = new WebClient())
            {
                ViewBag.Content = client.DownloadString("https://igwebprodcontent.blob.core.windows.net/integround-hubi-web/components-documentation.xml");
            }
            
            return View();
        }
    }
}