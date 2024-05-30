using Falcon.Core.Entities;
using Falcon.Core.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FalconWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        ICountryRepository countryRepository { get; set; }
        public CountryController(ICountryRepository countryRepository)
        {
            this.countryRepository = countryRepository;   
        }
        [HttpGet]
        public async Task<IList<Country>> Country()
        {
            try
            {
                return await this.countryRepository.GetAllCountry();
            }
            catch (Exception ex)
            {

                throw;
            }
        
        }

    }
}
