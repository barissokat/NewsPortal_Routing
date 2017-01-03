using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace NewsPortal_Routing.RouteConstraints
{
    public class CategoryRouteConstraints : IRouteConstraint
    {
        public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
        {
            int routePlace = values.Count() - 3;
            string categoryName = values["category" + routePlace].ToString();
            List<string> categories = new List<string> { "Money", "Tech", "Sport", "Travel" };
            if (categories.Contains(categoryName))
                return true;
            else
                return false;
        }
    }
}