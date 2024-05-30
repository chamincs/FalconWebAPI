using Falcon.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Falcon.Core.Interface
{
	public interface IUserService
	{
		public Task<User> Register(User user);

		public Task<User> UpdateUser(User user);
		public Task<User> GetUser(int userId);
	}
	
}
