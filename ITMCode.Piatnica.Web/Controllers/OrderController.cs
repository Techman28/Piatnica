using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ITMCode.Piatnica.Web.Controllers
{
    public class OrderController : Controller
    {
         private readonly HttpClient _httpClient;

        public OrderController(IHttpClientFactory httpClientFactory)
        {
             _httpClient = httpClientFactory.CreateClient("PiatnicaApi");
        }

        public IActionResult OrderList()
        {
            return View("OrderList");
        }

        public IActionResult AddOrder()
        {
            return View();
        }
        public IActionResult DetailOrder()
        {
            return View("DetailOrder");
        }

    }
}
