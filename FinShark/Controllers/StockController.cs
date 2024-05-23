using FinShark.Data;
using Microsoft.AspNetCore.Mvc;
// ReSharper disable ConvertToPrimaryConstructor

namespace FinShark.Controllers;

[Route("api/stock")]
[ApiController]
public class StockController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public StockController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var stocks = _context.Stocks.ToList();

        return Ok(stocks);
    }
}