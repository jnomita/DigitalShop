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
            var product = proRes.GetHaveCategoryProductByUrl(producturl);
            AddRecentlyViewed(proRes.GetProductByUrl(producturl));
            return View(product);
        }
    }
}