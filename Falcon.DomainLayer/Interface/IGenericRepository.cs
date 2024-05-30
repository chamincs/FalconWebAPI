using Falcon.Core.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Falcon.Core
{
	public interface IGenericRepository<T> 
	{
		Task<IReadOnlyList<T>> GetAllAsync();
		Task<T> GetByIdAsync(int id);

		Task<T> GetEntityWithSpec(ISpecifications<T> specification);
		Task<IReadOnlyList<T>> ListAsync(ISpecifications<T> specification);
		Task<int> CountAsync(ISpecifications<T> specifications);
		void DeleteAsync(T entity);
		void UpdateAsync(T entity);
	}
}
