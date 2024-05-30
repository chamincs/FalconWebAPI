using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Falcon.Core.Entities
{
    public class WeatherEvent
    {
        public int WeatherEventId { get; set; }
        public string? WeatherEventName { get; set; }
        public string? Description { get; set; }

        public Country? Country { get; set; }  
        public WeatherType? WeatherType { get; set; }
        public string? Location { get; set; }
        
        public DateTime StartDate { get; set; }
        
        public DateTime EndDate { get; set; }



    }
}
