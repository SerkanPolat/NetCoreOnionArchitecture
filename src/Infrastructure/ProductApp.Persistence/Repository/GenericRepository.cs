using Microsoft.EntityFrameworkCore;
using ProductApp.Application.Interfaces.Repository;
using ProductApp.Domain.Common;
using ProductApp.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductApp.Persistence.Repository
{
	public class GenericRepository<T> : IGenericRepository<T> where T:BaseEntity
	{
		private readonly ApplicationDbContext context;
		public GenericRepository(ApplicationDbContext context)
		{
			this.context = context;
		}
		public async Task<T> AddAsync(T entity)
		{
			await context.Set<T>().AddAsync(entity);
			await context.SaveChangesAsync();
			return entity;
		}

		public async Task<List<T>> GetAllAsync()
		{
			return await context.Set<T>().ToListAsync();
		}

		public async Task<T> GetByIdAsync(Guid Id)
		{
			return await context.Set<T>().FindAsync(Id);
		}
	}
}
