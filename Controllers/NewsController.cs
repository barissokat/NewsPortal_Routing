using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsPortal_Routing.Controllers
{
    public class NewsController : Controller
    {
        public ActionResult Details(string news)
        {
            ViewBag.NewsName = news.Replace("-", " ");
            return View();
        }
        public ActionResult Archive(string date, string news)
        {
            int routePlaceDate = this.RouteData.Values.Count() - 5;
            int routePlaceCategory = this.RouteData.Values.Count() - 5;
            int routePlaceNews = this.RouteData.Values.Count() - 3;
            string dateVal = this.RouteData.Values["date"].ToString();
            string category = this.RouteData.Values["category" + routePlaceCategory].ToString();
            string newsVal = this.RouteData.Values["news"].ToString();
            dateVal = dateVal.Replace("-", ".");
            newsVal = newsVal.Replace("-", " ");
            ViewBag.Date = dateVal;
            ViewBag.Category = category;
            ViewBag.News = newsVal;
            return View();
        }
    }
}