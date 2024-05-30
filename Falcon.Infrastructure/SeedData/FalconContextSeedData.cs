using Falcon.Core.Entities;
using Falcon.Infrastructure.Data;
using Microsoft.Extensions.Logging;
using System.Text.Json;


namespace Falcon.Infrastructure.SeedData
{
	public class FalconContextSeedData
	{
		public static async Task SeedAsync(FalconContext falconContext, ILoggerFactory loggerFactory)
		{
			try
			{
				if (!falconContext.Countries.Any()) {

					var countryData =  File.ReadAllText("../FalconWebAPI/Falcon.Infrastructure/SeedData/CountryList.json");

					var results =JsonSerializer.Deserialize<List<Country>>(countryData);
					if (results != null)
					{
						falconContext.Countries.AddRange(results);
						falconContext.SaveChanges();
					}
				}
			}
			catch (Exception ex)
			{
				var logger = loggerFactory.CreateLogger<FalconContext>();
				logger.LogError(ex, "Logger requested");
				throw;
			}
		}
    }
}
