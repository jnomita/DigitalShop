using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DigitalShop.Controllers
{
    public class ProductController : BaseController
    {
        public IActionResult Index(string producturl)
        {
            var product = proRes.GetProductByUrl(producturl);
            AddRecentlyViewed(product);
            return View();
        }
    }
}