using System.ComponentModel.DataAnnotations;

namespace ProductPricingCalculator.Models;

public class PricingModel
{
    [Required]
    public decimal ProductCost { get; set; }
    [Required]
    public decimal ProfitMargin { get; set; }
    [Required]
    public decimal ShippingCost { get; set; }
    [Required]
    public decimal Kdv { get; set; }
    [Required]
    public decimal CommissionRate { get; set; }
    [Required]
    public decimal ServiceFee { get; set; } = 8.4M;
    [Required]
    public decimal PackagingCost { get; set; }
}