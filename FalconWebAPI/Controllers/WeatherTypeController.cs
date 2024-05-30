using Falcon.Core.Entities;
using Falcon.Core.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FalconWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherTypeController : ControllerBase
    {
        IWeatherTypeRepository weatherTypeRepository { get; set; }
        public WeatherTypeController(IWeatherTypeRepository weatherTypeRepository)
        {
            this.weatherTypeRepository = weatherTypeRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<WeatherType>> WeatherTypes()
        {
            try
            {
                return await this.weatherTypeRepository.GetAllWeatherType();
            }
            catch (Exception ex)
            {

                throw;
            }

        }
    }
}
