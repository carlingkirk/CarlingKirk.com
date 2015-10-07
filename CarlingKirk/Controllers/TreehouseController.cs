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
            try
            {
                ViewBag.FilePath = Server.MapPath("~");
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message + " - " + ex.InnerException;
            }
            return View();
        }
    }
}
