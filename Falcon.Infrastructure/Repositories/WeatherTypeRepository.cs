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
    public class WeatherTypeRepository : IWeatherTypeRepository
    {
        private readonly FalconContext falconContext;
        public WeatherTypeRepository(FalconContext falconContext)
        {
            this.falconContext = falconContext;
        }
        
        public Task<WeatherType> AddWeatherType(WeatherType weatherType)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<WeatherType>> GetAllWeatherType()
        {
           return await this.falconContext.WeatherType.AsQueryable().ToListAsync();
        }

        public Task<WeatherType> GetWeatherType(string weatherTypeCode)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveWeatherType(int weatherTypeCode)
        {
            throw new NotImplementedException();
        }

        public Task<WeatherType> UpdateWeatherType(WeatherType weatherType)
        {
            throw new NotImplementedException();
        }
    }
}
