using Microsoft.AspNetCore.Mvc.Filters;

namespace ActionFilters.Filters;


public class SampleFilter : IActionFilter
{
    //Before Action Executed
    public void OnActionExecuted(ActionExecutedContext context)
    {
        Console.WriteLine("Sample Action Filter Synch Before");
    }


    //After Action Executed
    public void OnActionExecuting(ActionExecutingContext context)
    {
        Console.WriteLine("Sample Action Filter Synch After");
    }
}

public class SampleAsyncFilter : IAsyncActionFilter
{
    public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
        Console.WriteLine("Sample Action Filter ASync Before");
        await next();
        Console.WriteLine("Sample Action Filter ASync After");
    }
}