﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProductApp.Application.Interfaces.Repository;
using ProductApp.Persistence.Context;
using ProductApp.Persistence.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductApp.Persistence
{
	public static class ServiceRegistration
	{
		public static void AddPersistenceServices(this IServiceCollection serviceCollection)
		{
			serviceCollection.AddDbContext<ApplicationDbContext>(opt=>opt.UseInMemoryDatabase("memoryDb"));

			serviceCollection.AddScoped<IProductRepository, ProductRepository>();
		}
	}
}
