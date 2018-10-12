using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DigitalShop.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index(string producturl)
        {
            return View();
        }
    }
}