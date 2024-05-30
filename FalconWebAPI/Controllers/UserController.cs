using Falcon.Core.Entities;
using Falcon.Core.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FalconWebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UserController : ControllerBase
	{
		private readonly IUserService userService; 
		public UserController(IUserService userService) 
		{
			this.userService = userService;
		}
		[HttpPost]
		public async Task<User> Register(User user)
		{
			return await userService.Register(user);
		}
		[HttpGet]

		public async Task<User> GetUser(int userId)
		{
			return await userService.GetUser(userId);
		}
		[HttpPut]
		public async Task<User> UpdateUser(User user)
		{
			return await userService.UpdateUser(user);
		}
	}
}
