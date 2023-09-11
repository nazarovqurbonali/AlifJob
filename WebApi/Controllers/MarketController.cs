using Domain;
using Infrasructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;
[ApiController]
[Route("[controller]")]
public class MarketController:Controller
{
    private readonly IProductService _productService;

    public MarketController(IProductService productService)
    {
        _productService = productService;
    }
    [HttpGet("/api/market")]
    public async Task<IActionResult> Get([FromQuery]Product product,int summa,string phone ,Diapazon diapazon)
    {
        if (ModelState.IsValid)
        {
            var result = await _productService.GetProductAsync(product,summa,phone,diapazon);
            return StatusCode((int)result.StatusCode, result);
        }
        return BadRequest();
    }
    
}