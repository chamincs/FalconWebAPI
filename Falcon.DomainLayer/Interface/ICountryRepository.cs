using Falcon.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Falcon.Core.Interface
{
	public interface ICountryRepository
    {
        public Task<Country> AddCountry(Country country);
        public Task<IList<Country>> GetAllCountry();
        public Task<Country> GetCountry(string countryId);
        public Task<bool> RemoveCountry(int countryId);
        public Task<Country> UpdateCountry(Country country);

    }
}
