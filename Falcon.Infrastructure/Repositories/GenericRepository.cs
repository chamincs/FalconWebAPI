using Falcon.Core;
using Falcon.Core.Interface;
using Falcon.Core.Specification;
using Falcon.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Falcon.Infrastructure.Repositories
{
	public class GenericRepository<T>:IGenericRepository<T> where T : class
	{
		private readonly FalconContext falconContext;
		public GenericRepository(FalconContext falconContext) 
		{
			this.falconContext = falconContext;
		}
		public async Task<IReadOnlyList<T>> GetAllAsync()
		{
			try
			{
				return await falconContext.Set<T>().ToListAsync();
			}
			catch (Exception)
			{

				throw;
			}
		}

		public async Task<T> GetByIdAsync(int id)
		{
			try
			{
				return await falconContext.Set<T>().FindAsync(id);
			}
			catch (Exception)
			{

				throw;
			}
		}

		//Specification Pattern
		public async Task<T> GetEntityWithSpec(ISpecifications<T> specification)
		{
			return await ApplySpecification(specification).FirstOrDefaultAsync();
		}
		public async Task<IReadOnlyList<T>> ListAsync(ISpecifications<T> specification)
		{
			return await ApplySpecification(specification).ToListAsync();
		}
		public async Task<int> CountAsync(ISpecifications<T> specifications)
		{
			return await ApplySpecification(specifications).CountAsync();
		}
		private IQueryable<T> ApplySpecification(ISpecifications<T> specifications)
		{
			return SpecificationEvaluatOr<T>.GetQuery(falconContext.Set<T>().AsQueryable(), specifications);
		}

		public void Add(T entity)
		{
			falconContext.Add<T>(entity);
		}

		public void UpdateAsync(T entity)
		{
			falconContext.Attach<T>(entity);
			falconContext.Entry(entity).State = EntityState.Modified;
		}
		public void DeleteAsync(T entity)
		{
			falconContext.Set<T>().Remove(entity);

		}


	}
}
