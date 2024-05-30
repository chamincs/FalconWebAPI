﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Falcon.Core.Entities
{
	public class Address
	{
        public int AddressId { get; set; }
		public string StreetLine { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public Country Country { get; set; }
		public string ZipCode { get; set; }
    }
}
