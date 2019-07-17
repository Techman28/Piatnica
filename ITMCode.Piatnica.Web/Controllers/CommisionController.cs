using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ITMCode.Piatnica.Web.Controllers
{
    public class CommisionController : Controller
    {
        private readonly HttpClient _httpClient;

        public CommisionController(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("PiatnicaApi");
        }

        public IActionResult List()
        {
            return View("List");
        }

        
    }
}
