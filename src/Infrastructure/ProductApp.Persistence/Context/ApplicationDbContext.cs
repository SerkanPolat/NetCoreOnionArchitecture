using Microsoft.EntityFrameworkCore;
using ProductApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductApp.Persistence.Context
{
	public class ApplicationDbContext : DbContext
	{
		public DbSet<Product> Products { get; set; }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Product>().HasData(
				new Product()
				{
					CreateDate = DateTime.Now,
					Id = new Guid(),
					Name = "Kalem",
					Quantity = 100,
					Value = 10,
				}, new Product()
				{
					CreateDate = DateTime.Now,
					Id = new Guid(),
					Name = "Kitap",
					Quantity = 10,
					Value = 25,
				},new Product()
				{
					CreateDate = DateTime.Now,
					Id = new Guid(),
					Name = "Kagit",
					Quantity = 40000,
					Value = 5,
				}
				) ;
			base.OnModelCreating(modelBuilder);
		}
	}
}
