using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            //string connstring = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            //return Content(connstring);
            return View();

        }
    }
}