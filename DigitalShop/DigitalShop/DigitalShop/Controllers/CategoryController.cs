using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DigitalShop.Controllers
{
    public class CategoryController : BaseController
    {
        public IActionResult Index(string categoryurl)
        {
            var category = catRes.GetHaveProductCategoryByUrl(categoryurl);
            return View(category);
        }
    }
}