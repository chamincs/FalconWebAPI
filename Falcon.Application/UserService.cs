using Falcon.Core.Entities;
using Falcon.Core.Interface;


namespace Falcon.Application
{
	public class UserService : IUserService
	{
		private readonly IUserRepository userRepository;
        public UserService(IUserRepository userRepository)
        {
			this.userRepository = userRepository;
        }
        public async Task<User> Register(User user)
		{
			return await this.userRepository.AddUser(user);
		}

		public async Task<User> UpdateUser(User user)
		{
			return await this.userRepository.UpdateUser(user);
		}
		public async Task<User> GetUser(int userId)
		{
			return await this.GetUser(userId);
		}
	}
}
