using EndPointsFilters.Filters;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

#region Register on Specific End Point
// app.MapGet("api/products", () =>
// {
//     return new[] { "Iphone 17 pro max [$1100]", "Mac book pro [$2000]" };
// }).AddEndpointFilter<EnvelopResultFilter>()
//     .AddEndpointFilter<TrackActionTimeFilter>();
#endregion

#region Register Global

// var api = app.MapGroup("api")
// .AddEndpointFilter<EnvelopResultFilter>()
//     .AddEndpointFilter<TrackActionTimeFilter>();

// api.MapGet("/products", () =>
// {
//     return new[] { "Iphone 17 pro max [$1100]", "Mac book pro [$2000]" };
// });

// api.MapGet("/employees", () =>
// {
//     return new[] { "Abdalaleem [AI]", "Reem [HR]" };
// });

#endregion

#region Register on Specific Group
var productsEndpoints = app.MapGroup("api/products")
.AddEndpointFilter<EnvelopResultFilter>()
    .AddEndpointFilter<TrackActionTimeFilter>()
    .AddEndpointFilter<TenantResourceFilter>();

var employeesEndpoints = app.MapGroup("api/employees")
.AddEndpointFilter<EnvelopResultFilter>();

productsEndpoints.MapGet("", () =>
{
    return new[] { "Iphone 17 pro max [$1100]", "Mac book pro [$2000]" };
});

productsEndpoints.MapGet("/{id:int}", (int id) =>
{
    return "Iphone 17 pro max [$1100]";
});


employeesEndpoints.MapGet("", () =>
{
    return new[] { "Abdalaleem [AI]", "Reem [HR]" };
});
#endregion

app.Run();
