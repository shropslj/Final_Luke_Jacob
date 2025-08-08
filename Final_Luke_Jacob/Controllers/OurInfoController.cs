using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Final_Luke_Jacob.Database;
using Final_Luke_Jacob.Models;

namespace Final_Luke_Jacob.Controllers
{
    public class OurInfoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
