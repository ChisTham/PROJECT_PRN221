var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "1234");

app.Run();
