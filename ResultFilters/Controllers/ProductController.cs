using Microsoft.AspNetCore.Mvc;

namespace ResultFilters.Controllers;


[ApiController]
[Route("api/products")]
public class ProductController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new[] { "MacBook Pro [$3000.00]", "IPhone 16 pro [$900.77]", "Samsung S25 Ultra [$950.77]", "IPad Pro 2025 [$1100.77]" });
    }
}