using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class BooksController : Controller
    {
        public ActionResult Detail()
        {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Saturday)
            {
                //return new RedirectResult("/");
                return Redirect("/");
            }
            return new ContentResult() {
                Content = "Hello from Book Controller on " + DateTime.Today.DayOfWeek
            };
        }
    }
}