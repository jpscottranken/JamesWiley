using Microsoft.AspNetCore.Mvc;

namespace CaseStudy.Controllers
{
    public class ProductController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
