using DistanceConverter.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DistanceConverter.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}