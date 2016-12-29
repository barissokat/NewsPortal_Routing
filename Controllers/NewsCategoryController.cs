using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsPortal_Routing.Controllers
{
    public class NewsCategoryController : Controller
    {
        public ActionResult HomePage()
        {
            int routePlace = this.RouteData.Values.Count() - 3;
            string category = this.RouteData.Values["category" + routePlace].ToString();
            ViewBag.CategoryName = category;
            return View();
        }
    }
}