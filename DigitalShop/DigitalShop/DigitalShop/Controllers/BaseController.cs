using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigitalShop.Data.Repo;
using Microsoft.AspNetCore.Mvc;

namespace DigitalShop.Controllers
{
    public class BaseController : Controller
    {
        public CategoryRepository catRes = new CategoryRepository();
        public ProductRepository proRes = new ProductRepository();
        public CustomerRepository cusRes = new CustomerRepository();
        public OrderRepository ordRes = new OrderRepository();
        public OrderItemRepository oriRes = new OrderItemRepository();
    }
}