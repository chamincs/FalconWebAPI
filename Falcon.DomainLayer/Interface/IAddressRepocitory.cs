using Falcon.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Falcon.Core.Interface
{
	public interface IAddressRepocitory
	{
		public Task<Address> AddAddress(Address address);
		public Task<bool> RemoveAddress(int addessId);
		public Task<Address> UpdateAddress(Address address);

		public Task<Address> GetAddress(string addessId);
	}
}
