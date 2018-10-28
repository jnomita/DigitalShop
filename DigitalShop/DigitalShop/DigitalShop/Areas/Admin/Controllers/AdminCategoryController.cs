using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigitalShop.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DigitalShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class AdminCategoryController : BaseController
    {
        public IActionResult Index()
        {
            var modes = catRes.GetCategories();
            return View(modes);
        }

        [HttpGet]
        public IActionResult Edit(int id=0)
        {
            var model = catRes.GetCategoryByID(id);
            if (id == 0)
            {
                model = new Category();
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(Category model)
        {
            if (model.CategoryID != 0)
            {
                catRes.Update(model);
            }
            else
            {
                catRes.Add(model);
            }
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            catRes.Delete(id);
            return RedirectToAction("Index");
        }
    }
}