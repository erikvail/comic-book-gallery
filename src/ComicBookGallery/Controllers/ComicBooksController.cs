using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult DetailOld()
        {

            if (DateTime.Today.DayOfWeek == DayOfWeek.Sunday )
            {
                // return  new RedirectResult("/"); 
                return Redirect("/");
            }

            /*
            return new ContentResult()
            {
               
                Content = "Hello form the Comic Book Controller"
            };
            */

            return Content("Hello form the Comic Book Controller");

        }

        public ActionResult Detail()
        {
            return View();
        }
    }
}