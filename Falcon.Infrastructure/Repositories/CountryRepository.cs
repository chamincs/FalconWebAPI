using Falcon.Core.Entities;
using Falcon.Core.Interface;
using Falcon.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Falcon.Infrastructure.Repositories
{
    public class CountryRepository : ICountryRepository
    {
        private readonly FalconContext falconContext;
        public CountryRepository(FalconContext falconContext)
        {
            this.falconContext = falconContext;
        }
        

        public  Task<Country> AddCountry(Country country)
        {
            throw  new NotImplementedException();
        }

        public async Task<IList<Country>> GetAllCountry()
        {
            return await this.falconContext.Countries.AsQueryable().ToListAsync();
        }

        public async Task<Country> GetCountry(string countryId)
        {
            throw new NotImplementedException();
        }

        public  async Task<bool> RemoveCountry(int countryId)
        {
            throw new NotImplementedException();
        }

        public Task<Country> UpdateCountry(Country country)
        {
            throw new NotImplementedException();
        }

        
    }
}
