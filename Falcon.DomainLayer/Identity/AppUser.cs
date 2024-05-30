using Microsoft.AspNetCore.Identity;


namespace Falcon.Core
{
	public class AppUser : IdentityUser
	{
		public string DisplayName { get; set; }
	}
}
