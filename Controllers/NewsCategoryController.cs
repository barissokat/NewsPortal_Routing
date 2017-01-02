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

        public ActionResult Archive(string date)
        {
            int routePlaceDate = this.RouteData.Values.Count() - 3;
            int routePlaceCategory = this.RouteData.Values.Count() - 4;
            string dateVal = this.RouteData.Values["date"].ToString();
            string category = this.RouteData.Values["category" + routePlaceCategory].ToString();
            dateVal = dateVal.Replace("-", ".");
            ViewBag.CategoryName = dateVal + " - " + category;
            return View();
        }
    }
}