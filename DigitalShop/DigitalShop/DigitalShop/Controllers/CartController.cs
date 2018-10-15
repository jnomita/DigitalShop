﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigitalShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace DigitalShop.Controllers
{
    public class CartController : BaseController
    {
        public IActionResult Index()
        {
            var cart = GetCart();
            return View(cart);
        }

        public IActionResult Add(int id)
        {
            var cart = GetCart();
            var product = proRes.GetProductByID(id);
            if (cart.Items.Any(p => p.Product.ProductID == product.ProductID))
            {
                var item = cart.Items.FirstOrDefault(p => p.Product.ProductID == product.ProductID);
                item.Qty = item.Qty + 1;
            }
            else
            {
                cart.Items.Add(new Models.CartItemModel() {Product = product,Qty=1 });
            }
            SetCart(cart);
            return RedirectToAction("Index");
        }

        public IActionResult AddWithNumber(int id,int quantity)
        {
            var cart = GetCart();
            var product = proRes.GetProductByID(id);
            if (cart.Items.Any(p => p.Product.ProductID == product.ProductID))
            {
                var item = cart.Items.FirstOrDefault(p => p.Product.ProductID == product.ProductID);
                item.Qty = item.Qty + quantity;
            }
            else
            {
                cart.Items.Add(new Models.CartItemModel() {Product = product,Qty=quantity });
            }
             SetCart(cart);
            return RedirectToAction("Index");
        }

        public IActionResult RemoveItem(int id)
        {
            var cart = GetCart();
            if (cart.Items.Any(p => p.Product.ProductID == id))
            {
                var item = cart.Items.FirstOrDefault(p => p.Product.ProductID == id);
                cart.Items.Remove(item);
                
            }
            SetCart(cart);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Update(IEnumerable<CartUpdateItemModel> data)
        {
            var cart = GetCart();
            foreach (var it in data)
            {
                var product = proRes.GetProductByID(it.ProductID);
                if (cart.Items.Any(p => p.Product.ProductID == product.ProductID))
                {
                    var item = cart.Items.FirstOrDefault(p => p.Product.ProductID == product.ProductID);
                    item.Qty = it.Qty;
                }
            }
            SetCart(cart);
            return RedirectToAction("Index");
        }
    }
}