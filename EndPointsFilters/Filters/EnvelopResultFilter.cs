
namespace EndPointsFilters.Filters;


public class EnvelopResultFilter : IEndpointFilter
{
    public async ValueTask<object?> InvokeAsync(EndpointFilterInvocationContext context, EndpointFilterDelegate next)
    {
        var result = await next(context);

        return Results.Json(new
        {
            Success = result,
            data = result
        });
    }
}
