using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ITMCode.Piatnica.Web.Controllers
{
    public class VechicleController : Controller
    {
        private readonly HttpClient _httpClient;

        public VechicleController(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("PiatnicaApi");
        }

        public IActionResult VechicleList()
        {
            return View("VechicleList");
        }



    }
}