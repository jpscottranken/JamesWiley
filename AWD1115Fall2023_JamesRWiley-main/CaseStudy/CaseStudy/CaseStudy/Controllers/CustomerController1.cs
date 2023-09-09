using Microsoft.AspNetCore.Mvc;

namespace CaseStudy.Controllers
{
    public class CustomerController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
