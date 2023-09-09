using Microsoft.AspNetCore.Mvc;
using System;

public class DistanceConverterController : Controller
{
    private const double CM_PER_IN = 2.54;

    public double Inches { get; private set; }
    public double Centimeters { get; private set; }

    [HttpGet]
    public ActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Index(DistanceConverterController model)
    {
        if (ModelState.IsValid)
        {
            double inches = model.Inches;
            double centimeters = inches * CM_PER_IN;

            model.Centimeters = centimeters;

            return View(model);
        }

        return View(model);
    }
}

