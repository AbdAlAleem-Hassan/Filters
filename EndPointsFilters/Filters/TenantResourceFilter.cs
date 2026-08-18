using Microsoft.AspNetCore.Mvc;

namespace EndPointsFilters.Filters;

public class TenantResourceFilter(IConfiguration configuration) : IEndpointFilter
{
    public async ValueTask<object?> InvokeAsync(EndpointFilterInvocationContext context, EndpointFilterDelegate next)
    {
        var tenant = context.HttpContext.Request.Headers["tenant"].ToString();
        var tenantK = context.HttpContext.Request.Headers["x-api-key"].ToString();

        var expectedTenantK = configuration[$"Tenant:{tenant}:ApiKey"];

        if(string.IsNullOrEmpty(expectedTenantK) || tenantK != expectedTenantK)
        {
            return new UnauthorizedResult();
        }
        return await next(context);
    }
}