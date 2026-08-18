using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ResourceFilters.Filters;

public class TenantValidationFilter(IConfiguration conf) : IAsyncResourceFilter
{
    public async Task OnResourceExecutionAsync(ResourceExecutingContext context, ResourceExecutionDelegate next)
    {
        var tenantId = context.HttpContext.Request.Headers["tenantId"].ToString();
        var tenantK = context.HttpContext.Request.Headers["x-api-key"].ToString();
        var expectedTenantK = conf[$"Tenants:{tenantId}:ApiKey"];

        if(string.IsNullOrEmpty(expectedTenantK) || tenantK != expectedTenantK)
        {
            context.Result = new UnauthorizedResult();
            return;
        }
       // await next();
    }
}