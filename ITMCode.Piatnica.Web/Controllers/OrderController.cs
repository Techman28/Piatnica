using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITMCode.Piatnica.Web.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult OrderList()
        {
            return View("OrderList");
        }
        public IActionResult AddOrder()
        {
            return View();
        }

    }
}
