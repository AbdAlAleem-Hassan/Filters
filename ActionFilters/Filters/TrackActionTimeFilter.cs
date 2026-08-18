using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ActionFilters.Filters;

public class TrackActionTimeFilter : IAsyncActionFilter
{
    public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
        Console.WriteLine("Track Action Time Filter Started");
        context.HttpContext.Items["ActionStartTime"] = DateTime.UtcNow;

        await next(); //Execute Action 

        var elapsed = DateTime.UtcNow - (DateTime)context.HttpContext.Items["ActionStartTime"]!;

        context.HttpContext.Response.Headers.Append("X-Elapsed-Time", $"{elapsed.TotalMilliseconds}ms");
        Console.WriteLine($"Track Action Time Filter Took {elapsed.TotalMilliseconds}ms");
    }
}