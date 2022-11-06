using Api.Middlewares;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddSingleton<MyCustomExceptionMiddleware>();
var app = builder.Build();

app.UseMiddleware<MyCustomExceptionMiddleware>();

app.MapControllers();

app.Run();
