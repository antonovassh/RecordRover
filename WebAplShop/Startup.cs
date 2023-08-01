using WebAplShop.Data.Interfaces;
using WebAplShop.Mocks;

namespace WebAplShop
{
	public class Startup
	{
			public void ConfigureServices(IServiceCollection services)
			{
				services.AddTransient<IStorekeeper, MockPlates>();
				services.AddTransient<IPlateCategorizer, MockCategory>();
				services.AddMvc(option => option.EnableEndpointRouting = false);
			}
			public void Configure(IApplicationBuilder app, IHostEnvironment env)

			{
				app.UseDeveloperExceptionPage();
				app.UseStatusCodePages();
				app.UseStaticFiles();
				app.UseMvcWithDefaultRoute();
			}
		}
	}

