using DigitalShop.Data.Repo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalShop.Constraint
{
    public class CategoryConstraint:IRouteConstraint
    {
         public bool Match(HttpContext httpContext, IRouter route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            var db = new CategoryRepository();
            var url = values[routeKey]?.ToString();
            return db.GetCategoryByUrl(url)!=null;
        }
    }
}
