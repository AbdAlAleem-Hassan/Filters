using ActionFilters.Filters;
using Microsoft.AspNetCore.Mvc;

namespace ActionFilters.Controllers;

[ApiController]
[Route("api/products")]
public class ProductController : ControllerBase
{
    [HttpGet]
    [TrackActionTimeFilterV3]
    public IActionResult Get()
    {
        return Ok(new[] { "Keyboard [$50.99]", "Iphone 17 Pro Max [$1000.45]" });
    }
}