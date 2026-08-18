using ActionFilters.Filters;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers(options =>
{
    //options.Filters.Add<TrackActionTimeFilter>();
});
var app = builder.Build();

app.MapControllers();

app.Run();
