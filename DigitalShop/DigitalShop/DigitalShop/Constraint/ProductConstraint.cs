using DigitalShop.Data.Repo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalShop.Constraint
{
    public class ProductConstraint:IRouteConstraint
    {
         public bool Match(HttpContext httpContext, IRouter route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            var db = new ProductRepository();
            var url = values[routeKey]?.ToString();
            return db.GetProductByUrl(url)!=null;
        }
    }
}
