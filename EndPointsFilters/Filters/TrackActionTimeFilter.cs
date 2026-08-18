
namespace EndPointsFilters.Filters;

public class TrackActionTimeFilter : IEndpointFilter
{
    public async ValueTask<object?> InvokeAsync(EndpointFilterInvocationContext context, EndpointFilterDelegate next)
    {
        var start = DateTime.UtcNow;

        var result = await next(context);

        var elapsed = DateTime.UtcNow - start;

        context.HttpContext.Response.Headers.Append("x-Elapsed", $"{elapsed.TotalMilliseconds}mm");
        Console.WriteLine($"Track Action Time Filter Took {elapsed.TotalMilliseconds}mm");
        return result;
    }
}