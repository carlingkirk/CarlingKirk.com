using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarlingKirk.Controllers
{
    public class TreehouseController : Controller
    {
        [Authorize(Roles ="Treehouse")]
        // GET: Treehouse
        public ActionResult Index()
        {
            ViewBag.FilePath = System.IO.Path.Combine(String.Format("{0}{1}video.{2}", System.Web.HttpContext.Current.Server.MapPath("~"), Constants.FilePath, "mp4"));
            return View();
        }
    }
}
