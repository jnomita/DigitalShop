﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DigitalShop.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index(string categoryurl)
        {
            return View();
        }
    }
}