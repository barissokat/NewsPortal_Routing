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
    }
}