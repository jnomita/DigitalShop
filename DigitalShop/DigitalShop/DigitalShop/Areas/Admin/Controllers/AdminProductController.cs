using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DigitalShop.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DigitalShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class AdminProductController : BaseController
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        public AdminProductController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Index()
        {
            var models = proRes.GetHaveCategoryProducts();
            return View(models);
        }

        [HttpGet]
        public IActionResult Edit(int id = 0)
        {
            var model = proRes.GetProductByID(id);
            if (id == 0)
            {
                model = new Product();
                
            }
            ViewBag.Categories = catRes.GetCategories();
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(Product model,IFormFile image)
        {
            if (image.Length > 0)
            {
                var fileName = DateTime.Now.ToString("ddMMyyyyHHmmss") + "." + image.FileName.Split(".").LastOrDefault();
                var path = Path.Combine(_hostingEnvironment.WebRootPath + "/img", fileName);
                image.CopyTo(new FileStream(path, FileMode.Create));
                model.ProductImage = fileName;
            }
            if (model.ProductID != 0)
            {
                proRes.Update(model);
            }
            else
            {
                proRes.Add(model);
            }
           
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            proRes.Delete(id);
            return RedirectToAction("Index");
        }
    }
}