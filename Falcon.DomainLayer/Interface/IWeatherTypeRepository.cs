using Falcon.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Falcon.Core.Interface
{
    public interface IWeatherTypeRepository
    {
        public Task<WeatherType> AddWeatherType(WeatherType weatherType);
        public Task<IList<WeatherType>> GetAllWeatherType();
        public Task<WeatherType> GetWeatherType(string weatherTypeCode);
        public Task<bool> RemoveWeatherType(int weatherTypeCode);
        public Task<WeatherType> UpdateWeatherType(WeatherType weatherType);
    }
}
