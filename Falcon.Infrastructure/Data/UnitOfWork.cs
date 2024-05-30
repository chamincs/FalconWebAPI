using Falcon.Core;
using Falcon.Core.Interface;
using Falcon.Infrastructure.Repositories;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Falcon.Infrastructure.Data
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly FalconContext _context;
		private Hashtable _repositories;
        public UnitOfWork(FalconContext context)
        {
			_context = context;

		}
        public async Task<int> Complete()
		{
			return await _context.SaveChangesAsync();
		}
		public void Dispose()
		{
			_context.Dispose();
		}

        public IGenericRepository<TEntity> repository<TEntity>()
        {
            throw new NotImplementedException();
        }

        //public IGenericRepository<TEntity> repository<TEntity>()
        //{
        //	if (_repositories == null) _repositories = new Hashtable();
        //	var Type = typeof(TEntity).Name;
        //	if (!_repositories.ContainsKey(Type))
        //	{
        //		var repositiryType = typeof(GenericRepository<>);
        //		var repositoryInstance = Activator.CreateInstance(
        //			repositiryType.MakeGenericType(typeof(TEntity)), _context);
        //		_repositories.Add(Type, repositoryInstance);
        //	}
        //	return (IGenericRepository<TEntity>)_repositories[Type];
        //}
    }
}
