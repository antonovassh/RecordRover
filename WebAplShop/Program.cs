using VinylRecords;
using VinylRecords.Data.Interfaces;
using VinylRecords.Mocks;

var startup = new Startup();

var builder = WebApplication.CreateBuilder(args);

startup.ConfigureDb(builder.Configuration, builder.Services);
startup.ConfigureServices(builder.Services);

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

startup.Configure(app, app.Environment);

app.Run();