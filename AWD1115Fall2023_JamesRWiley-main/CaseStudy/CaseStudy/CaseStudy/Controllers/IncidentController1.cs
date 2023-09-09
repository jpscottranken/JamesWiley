using Microsoft.AspNetCore.Mvc;

namespace CaseStudy.Controllers
{
    public class IncidentController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
