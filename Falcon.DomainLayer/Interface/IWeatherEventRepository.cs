using Falcon.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Falcon.Core.Interface
{
    public interface IWeatherEventRepository
    {
        public Task<WeatherEvent> AddWeatherEvent(WeatherEvent weatherEvent);
        public Task<IList<WeatherEvent>> GetAllWeatherEvent();
        public Task<WeatherEvent> GetWeatherEvent(string weatherTypeCode);
        public Task<bool> RemoveWeatherEvent(int id);
        public Task<WeatherEvent> UpdateWeatherEvent(WeatherEvent weatherEvent);
    }
}
