namespace ProductPricingCalculator.Models;

public class PricingResult
{
    public decimal SalesPrice { get; set; }
    public decimal Commission { get; set; }
    public decimal NetKDV { get; set; }
    public decimal Profit { get; set; }
}