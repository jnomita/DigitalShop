using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DigitalShop.Models;
using DigitalShop.Data;
using Microsoft.AspNetCore.Http;

namespace DigitalShop.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            TestData addData= new TestData();
            var model = new HomeModel()
            {
                Categories = catRes.GetHaveProductCategories().ToList(),
                TopSeller =  proRes.GetTopSellProducts(),
                RecentlyViewed = GetRecentlyViewed(),
                TopNew = proRes.GetTopNewProducts()
            };
            return View(model);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
