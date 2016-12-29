using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsPortal_Routing.Controllers
{
    public class NewsCategoryController : Controller
    {
        public ActionResult HomePage(string category)
        {
            ViewBag.CategoryName = category;
            return View();
        }
    }
}