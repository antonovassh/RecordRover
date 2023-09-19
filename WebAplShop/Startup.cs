using VinylRecords.Data;
using VinylRecords.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using VinylRecords.Data.Reposytory;
using Microsoft.Extensions.Configuration;
using VinylRecords.Data.Models;

namespace VinylRecords;

public class Startup
{
	private IConfigurationRoot _confString;

	public Startup(Microsoft.AspNetCore.Hosting.IHostingEnvironment hostEnv)
	{
		_confString = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("dbsettings.json").Build();
	}

	public Startup()
	{
	}

	public void ConfigureServices(IServiceCollection services)
	{
		services.AddTransient<IAllPlates, PlateRepository>();
		services.AddTransient<IPlateCategorizer, CategoryRepository>();
		services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
		services.AddScoped(sp => ShopCart.GetCart(sp));
		services.AddMvc(option => option.EnableEndpointRouting = false);
		services.AddMemoryCache();
		services.AddSession();
	}

	public void ConfigureDb(IConfiguration config, IServiceCollection services)
	{
        services.AddDbContext<AppDBContent>(options => options.UseSqlServer(config.GetConnectionString("DefaultConnection")));
    }

	public void Configure(IApplicationBuilder app, IHostEnvironment env)

	{
		app.UseDeveloperExceptionPage();
		app.UseStatusCodePages();
		app.UseStaticFiles();
		app.UseSession();
		app.UseMvcWithDefaultRoute();

       
        using (var scope = app.ApplicationServices.CreateScope())
        {
            AppDBContent content = scope.ServiceProvider.GetRequiredService<AppDBContent>();
			DBObjects.Initial(content);
        }
    }
}