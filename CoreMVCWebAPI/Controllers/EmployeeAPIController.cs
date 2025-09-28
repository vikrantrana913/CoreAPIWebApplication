using CoreMVCWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreMVCWebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeeAPIController : Controller
    {

        private readonly EmployeeDbContext _db;

        public EmployeeAPIController(EmployeeDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return Ok(_db.GetEmployee());
        }
    }
}
