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
    public class WeatherEventRepository : IWeatherEventRepository
    {
        private readonly FalconContext falconContext;
        public WeatherEventRepository(FalconContext falconContext) {
         this.falconContext = falconContext;
        }
        public async Task<WeatherEvent> AddWeatherEvent(WeatherEvent weatherEvent)
        {
            this.falconContext.Add(weatherEvent);
            int id =  await this.falconContext.SaveChangesAsync();
            weatherEvent.WeatherEventId = id;
            return weatherEvent;
        }

        public async Task<IList<WeatherEvent>> GetAllWeatherEvent()
        {
            return await this.falconContext.WeatherEvents.Include(x=>x.Country).Include(y=>y.WeatherType).AsQueryable().ToListAsync();
        }

        public Task<WeatherEvent> GetWeatherEvent(string weatherTypeCode)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveWeatherEvent(int id)
        {
            throw new NotImplementedException();
        }

        public Task<WeatherEvent> UpdateWeatherEvent(WeatherEvent weatherEvent)
        {
            throw new NotImplementedException();
        }
    }
}
