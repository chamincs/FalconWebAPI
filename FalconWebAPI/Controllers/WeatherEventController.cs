using Falcon.Core.Entities;
using Falcon.Core.Interface;
using Falcon.Infrastructure.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FalconWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherEventController : ControllerBase
    {
        IWeatherEventRepository weatherEventRepository { get; set; }
        public WeatherEventController(IWeatherEventRepository weatherEventRepository)
        {
            this.weatherEventRepository = weatherEventRepository;
        }
        [HttpGet]
        public async Task<IEnumerable<WeatherEvent>> GetAllWeatherEvent()
        {
           return await this.weatherEventRepository.GetAllWeatherEvent();
        }

    }
}
