using WebAplShop;
using WebAplShop.Data.Interfaces;
using WebAplShop.Mocks;

var startup = new Startup();

var builder = WebApplication.CreateBuilder(args);
startup.ConfigureServices(builder.Services);

var app = builder.Build();

app.MapGet("/", () => "Hello World!");
startup.Configure(app, app.Environment);

app.Run();