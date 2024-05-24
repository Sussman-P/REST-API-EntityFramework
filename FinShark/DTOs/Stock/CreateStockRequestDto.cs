using System.ComponentModel.DataAnnotations.Schema;

namespace FinShark.DTOs.Stock;

public class CreateStockRequestDto
{
    public string Symbol { get; set; } = String.Empty;
    public string CompanyName { get; set; } = string.Empty;
    public decimal Purchase { get; set; }
    public decimal LastDiv { get; set; }
    public string Industry { get; set; } = string.Empty;
    public long MarketCap { get; set; }
}