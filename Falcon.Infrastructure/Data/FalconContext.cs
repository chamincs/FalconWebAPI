using Falcon.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Falcon.Infrastructure.Data
{
	public class FalconContext :DbContext
	{
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Country> Countries { get; set; } = null!;
        public DbSet<Address> Addresses { get; set; } = null!;

        public DbSet<WeatherType> WeatherType { get; set; } = null!;
        public DbSet<WeatherEvent> WeatherEvents { get; set; } = null!;
        public FalconContext(DbContextOptions<FalconContext> contextOptions):base(contextOptions)
        {
                
        }
    }
}
