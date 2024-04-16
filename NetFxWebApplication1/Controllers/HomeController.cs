using System.Web.Mvc;

namespace NetFxWebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            int unsedVariable;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            int unused2;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}