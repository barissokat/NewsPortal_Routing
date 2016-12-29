using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsPortal_Routing.App_Start
{
    public class WebsiteController : Controller
    {
        public ActionResult HomePage()
        {
            return View();
        }
        public ActionResult Archive()
        {
            return View();
        }
    }
}