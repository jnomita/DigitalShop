using DigitalShop.Data.Repo;
using DigitalShop.Domain;
using DigitalShop.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalShop
{
    public class CommonViewComponent:ViewComponent
    {
        protected CategoryRepository catRes = new CategoryRepository();
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var cartStr = HttpContext.Session.GetString("Cart");
            var products = cartStr != null &&  cartStr != ""  ? JsonConvert.DeserializeObject<CartModel>(cartStr).Items : new List<CartItemModel>();
            var model = new MenuAndHeaderModel()
            {
                Menus = catRes.GetCategories(),
                ProductsCart = products
            };
            return View("~/Views/Shared/_Header.cshtml", model);
        }
    }
}
