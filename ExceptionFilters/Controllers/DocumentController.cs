using Microsoft.AspNetCore.Mvc;

namespace ExceptionFilters.Controllers;


[ApiController]
[Route("api/documents")]
public class DocumentController : ControllerBase
{
    [HttpGet("{docNo}")]
    public IActionResult GetDocument(int docNo)
    {
        string file = "Somefile.pdf";

        var filePath = Path.Combine("c//SensitiveFiles", file);
        if (!System.IO.File.Exists(filePath))
        {
            throw new FileNotFoundException("File Not Found", filePath);
        }

        return PhysicalFile(filePath, "application/pdf", file);
    }
}