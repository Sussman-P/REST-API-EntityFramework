﻿using FinShark.Data;
using FinShark.Mappers;
using Microsoft.AspNetCore.Mvc;
// ReSharper disable ConvertToPrimaryConstructor
// ReSharper disable RouteTemplates.ParameterConstraintCanBeSpecified

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
        var stocks = _context.Stocks.ToList()
            .Select(s => s.ToStockDto());

        return Ok(stocks);
    }

    [HttpGet("{id}")]
    public IActionResult GetById([FromRoute] int id)
    {
        var stock = _context.Stocks.Find(id);

        if (stock == null)
        {
            return NotFound();
        }

        return Ok(stock.ToStockDto());
    }
}