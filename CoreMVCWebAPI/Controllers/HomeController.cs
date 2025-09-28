using System.Diagnostics;
using CoreMVCWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreMVCWebAPI.Controllers
{
    public class HomeController : Controller
    {
        private readonly HttpClient _client;

        public HomeController(IHttpClientFactory factory)
        {
            _client = factory.CreateClient("EmployeeAPI");
        }
       
        public async Task<IActionResult> Index()
        {
           var res=await _client.GetFromJsonAsync<List<EmployeeDbModel>>("EmployeeAPI/Index");
            return View(res);
        }

        public IActionResult Privacy()
        {
            return View();
        }


    }
}
