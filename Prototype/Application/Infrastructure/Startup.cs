using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Prototype.Application.Domain.Repository;
using Prototype.Business.Interfaces;
using Prototype.Business.Services;
using static System.Net.Mime.MediaTypeNames;

namespace Prototype.Application.Infrastructure
{
	public static class Startup
	{
		public static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
		{
			//Scheme: Routing - View Engine
			services.Configure<RazorViewEngineOptions>(o =>
			{
				o.ViewLocationFormats.Clear();
				o.ViewLocationFormats.Add("/Presentation/Views/{1}/{0}" + RazorViewEngine.ViewExtension);
				o.ViewLocationFormats.Add("/Presentation/Views/Shared/{0}" + RazorViewEngine.ViewExtension);
			});

			RegisterRepository(services, configuration);

			services.AddScoped<IProductService, ProductService>();
		}

		public static void Configure(IApplicationBuilder application)
		{

		}
		//Scheme: Routing - Request
		public static void ConfigureEndPoints(IEndpointRouteBuilder endpoint)
		{

			endpoint.MapControllerRoute(
				name: "default",
				pattern: "{controller=Home}/{action=Index}/{id?}");

		}
		//Scheme: DataLayer
		public static void RegisterRepository(IServiceCollection services, IConfiguration configuration)
		{
			services.AddDbContext<PrototypeDBContext>(opts =>
			{
				opts.UseSqlServer(configuration["ConnectionStrings:PrototypeConnection"]);
			});

			services.AddScoped(typeof(IRepository<>), typeof(EFRepository<>));
		}
	}
}
