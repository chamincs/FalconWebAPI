﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Falcon.Core.Entities
{
	public class User
	{
		public int UserId { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
		public string Email { get; set; }

		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime DateOfBirth { get; set; }
		public string PhoneNumber { get; set; }
		public Address Address { get; set; }
	}
}
