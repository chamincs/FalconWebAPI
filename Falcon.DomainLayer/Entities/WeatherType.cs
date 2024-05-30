using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Falcon.Core.Entities
{
    public class WeatherType
    {
        public int WeatherTypeId { get; set; }
        public string? WeatherTypeCode { get; set; }
        public string? WeatherTypeName { get; set; }
    }
}
