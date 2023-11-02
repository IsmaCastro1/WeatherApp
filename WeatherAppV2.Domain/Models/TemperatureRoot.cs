using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WeatherAppV2.Domain.Models
{
    public class TemperatureRoot
    {
        [JsonInclude]
        public string temperatura_actual { get; set; }
    }
}
