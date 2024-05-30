using Falcon.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Falcon.Core.Interface
{
	public interface IUserRepository
	{
		public Task<User> AddUser(User user);
		public Task<User> UpdateUser(User user);
		public Task<User> GetUserById(int userId);
		public Task<User> DeleteUser(int userId);

	}
}
