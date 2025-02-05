using Microsoft.AspNetCore.Mvc;
using ProductPricingCalculator.Models;
using ProductPricingCalculator.Services;

namespace ProductPricingCalculator.Controllers;

public class PricingController: Controller
{
    private readonly IPricingService _pricingService;

    public PricingController(IPricingService pricingService)
    {
        _pricingService = pricingService;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Calculate(PricingModel model)
    {
        if (!ModelState.IsValid)
        {
            return View("Index", model);
        }
        
        var result = _pricingService.CalculatePrice(model);
        return View("Result",result);
    }
    
}