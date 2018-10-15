﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigitalShop.Data.Repo;
using DigitalShop.Domain;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;

namespace DigitalShop.Controllers
{
    public class BaseController : Controller
    {
        protected CategoryRepository catRes = new CategoryRepository();
        protected ProductRepository proRes = new ProductRepository();
        protected CustomerRepository cusRes = new CustomerRepository();
        protected OrderRepository ordRes = new OrderRepository();
        protected OrderItemRepository oriRes = new OrderItemRepository();

        protected List<Product> GetRecentlyViewed()
        {
            var list = GetObjectFromJson<List<Product>>("RecentlyViewed");
            return list!=null && list.Any() ? list : new List<Product>();
        }
        protected void AddRecentlyViewed(Product RecentlyViewedProduct)
        {
            var list = GetObjectFromJson<List<Product>>("RecentlyViewed");
            if (list == null)
            {
                list = new List<Product>();
            }
            list.Add(RecentlyViewedProduct);
            SetObjectAsJson("RecentlyViewed", list);
        }

        private void SetObjectAsJson( string key, object value)
        {
             HttpContext.Session.SetString(key, JsonConvert.SerializeObject(value));
        }

        private T GetObjectFromJson<T>(string key)
        {
            var value =  HttpContext.Session.GetString(key);

            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }
    }
}