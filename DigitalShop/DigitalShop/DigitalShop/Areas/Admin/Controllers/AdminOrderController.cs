using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DigitalShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class AdminOrderController : BaseController
    {
        public IActionResult Index()
        {
            var orders = ordRes.GetOrders();
            return View(orders);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var order = ordRes.GetOrderByID(id);
            return View(order);
        }

        [HttpPost]
        public IActionResult Edit(int OrderID,int Status)
        {
            ordRes.UpdateStatus(OrderID, Status);
            return RedirectToAction("Index");
        }
    }
}