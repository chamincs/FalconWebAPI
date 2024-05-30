using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Falcon.Core.Interface
{
	public interface IUnitOfWork
	{
		IGenericRepository<TEntity> repository<TEntity>();
		Task<int> Complete();
	}
}
