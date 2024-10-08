var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => aspnetcore3._1.Controllers.HomeController.Index());

app.Run();
