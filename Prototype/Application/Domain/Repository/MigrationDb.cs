using Microsoft.EntityFrameworkCore;
using Prototype.Application.Domain.Entity;
using System.Xml.Linq;

namespace Prototype.Application.Domain.Repository
{
	public static class MigrationDb
	{
		public static void ProductData(IApplicationBuilder app)
		{
			PrototypeDBContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<PrototypeDBContext>();

			//TODO:  Crear un servicio install que recupere la ruta de los activos 
			var hostingEnvironment = app.ApplicationServices.GetRequiredService<IWebHostEnvironment>();
			//TODO:   Poner en configuración directorios aplicación. Descubrir en GN 
			var picturesPath = "assets\\pictures\\";


			if (context.Database.GetPendingMigrations().Any())
			{
				context.Database.Migrate();
			}

			if (!context.Products.Any())
			{
				context.Products.AddRange(
					new Product
					{
						Name = "Producto 1",
						Description = "Producto 1 Description",
						Price = 100,
						Unit = "kg",
						PicturePath = picturesPath + "item (1).jpg"
					},
					new Product
					{
						Name = "Producto 2",
						Description = "Producto 2 Description",
						Price = 100,
						Unit = "kg",
						PicturePath = picturesPath + "item (2).jpg"
					},
					new Product
					{
						Name = "Producto 3",
						Description = "Producto 3 Description",
						Price = 100,
						Unit = "kg",
						PicturePath = picturesPath + "item (3).jpg"
					},
					new Product
					{
						Name = "Producto 4",
						Description = "Producto 4 Description",
						Price = 100,
						Unit = "kg",
						PicturePath = picturesPath + "item (4).jpg"
					},
					new Product
					{
						Name = "Producto 5",
						Description = "Producto 5 Description",
						Price = 100,
						Unit = "kg",
						PicturePath = picturesPath + "item (5).jpg"
					},
					new Product
					{
						Name = "Producto 6",
						Description = "Producto 6 Description",
						Price = 100,
						Unit = "kg",
						PicturePath = picturesPath + "item (6).jpg"
					},
					new Product
					{
						Name = "Producto 7",
						Description = "Producto 7 Description",
						Price = 100,
						Unit = "kg",
						PicturePath = picturesPath + "item (7).jpg"
					},
					new Product
					{
						Name = "Producto 8",
						Description = "Producto 8 Description",
						Price = 100,
						Unit = "kg",
						PicturePath = picturesPath + "item (8).jpg"
					},
					new Product
					{
						Name = "Producto 9",
						Description = "Producto 9 Description",
						Price = 100,
						Unit = "kg",
						PicturePath = picturesPath + "item (9).jpg"
					},
					new Product
					{
						Name = "Producto 10",
						Description = "Producto 10 Description",
						Price = 100,
						Unit = "kg",
						PicturePath = picturesPath + "item (10).jpg"
					},
					new Product
					{
						Name = "Producto 11",
						Description = "Producto 11 Description",
						Price = 100,
						Unit = "kg",
						PicturePath = picturesPath + "item (11).jpg"
					},
					new Product
					{
						Name = "Producto 12",
						Description = "Producto 12 Description",
						Price = 100,
						Unit = "kg",
						PicturePath = picturesPath + "item (12).jpg"
					},
					new Product
					{
						Name = "Producto 13",
						Description = "Producto 13 Description",
						Price = 100,
						Unit = "kg",
						PicturePath = picturesPath + "item (13).jpg"
					},
					new Product
					{
						Name = "Producto 14",
						Description = "Producto 14 Description",
						Price = 100,
						Unit = "kg",
						PicturePath = picturesPath + "item (14).jpg"
					},
					new Product
					{
						Name = "Producto 15",
						Description = "Producto 15 Description",
						Price = 100,
						Unit = "kg",
						PicturePath = picturesPath + "item (15).jpg"
					},
					new Product
					{
						Name = "Producto 16",
						Description = "Producto 16 Description",
						Price = 100,
						Unit = "kg",
						PicturePath = picturesPath + "item (16).jpg"
					},
					new Product
					{
						Name = "Producto 16",
						Description = "Producto 16 Description",
						Price = 100,
						Unit = "kg",
						PicturePath = picturesPath + "item (16).jpg"
					},
					new Product
					{
						Name = "Producto 17",
						Description = "Producto 17 Description",
						Price = 100,
						Unit = "kg",
						PicturePath = picturesPath + "item (17).jpg"
					},
					new Product
					{
						Name = "Producto 18",
						Description = "Producto 18 Description",
						Price = 100,
						Unit = "kg",
						PicturePath = picturesPath + "item (18).jpg"
					},
					new Product
					{
						Name = "Producto 19",
						Description = "Producto 19 Description",
						Price = 100,
						Unit = "kg",
						PicturePath = picturesPath + "item (19).jpg"
					},
					new Product
					{
						Name = "Producto 20",
						Description = "Producto 20 Description",
						Price = 100,
						Unit = "kg",
						PicturePath = picturesPath + "item (20).jpg"
					},
					new Product
					{
						Name = "Producto 21",
						Description = "Producto 21 Description",
						Price = 100,
						Unit = "kg",
						PicturePath = picturesPath + "item (21).jpg"
					}

				);

				context.SaveChanges();
			}
		}
	}
}
