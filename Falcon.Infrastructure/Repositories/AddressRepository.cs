using Falcon.Core.Entities;
using Falcon.Core.Interface;
using Falcon.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Falcon.Infrastructure.Repositories
{
	public class AddressRepository :IAddressRepocitory
	{
		private readonly FalconContext falconContext;
        public AddressRepository(FalconContext falconContext)
        {
                this.falconContext = falconContext;
        }

		public async Task<Address> AddAddress(Address address)
		{
			var respose = await this.falconContext.AddAsync<Address>(address);
			this.falconContext.SaveChanges();
			return respose.Entity;
		}

		public async Task<Address> GetAddress(string addessId)
		{
			var result = await this.falconContext.Addresses.FindAsync(addessId);
			if (result==null) {
				throw new NullReferenceException("Result is null");
			}
			return result;
		}

		public async Task<bool> RemoveAddress(int addessId)
		{
			var address = this.falconContext.Addresses.FirstOrDefault(x => x.AddressId == addessId);
			if (address == null)
			{
				return false;
			}
			this.falconContext.Remove(address);
		  return await this.falconContext.SaveChangesAsync()>0;

		}

		public async Task<Address> UpdateAddress(Address address)
		{
			
			this.falconContext.Addresses.Update(address);
			await this.falconContext.SaveChangesAsync();
			var result = await this.falconContext.Addresses.FindAsync(address.AddressId);
			return result;
		}
	}
}
