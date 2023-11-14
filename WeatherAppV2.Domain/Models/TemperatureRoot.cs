using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using WeatherAppV2.Domain.Entities.EMunicipality;

namespace WeatherAppV2.Domain.Models
{
    public class TemperatureRoot
    {
		[JsonInclude]
		public Municipality municipio { get; set; }

		[JsonInclude]
		public StateSky stateSky { get; set; }

		[JsonInclude]
        public String temperatura_actual { get; set; }

		[JsonInclude]
		public Temperaturas temperaturas { get; set; }

		[JsonInclude]
        public String humedad { get; set; }

        [JsonInclude]
        public String viento { get; set; }

        [JsonInclude]
        public String precipitacion { get; set; }

        [JsonInclude]
        public String lluvia { get; set; }

        [JsonInclude]
        public Pronostico pronostico { get; set; }    


    }

    public class StateSky
	{
        [JsonInclude]
        public String description { get; set; }
    }

    public class Temperaturas
    {
        [JsonInclude]
        public String max { get; set; }

        [JsonInclude]
        public String min { get; set; }
    }
        
    public class Pronostico
    {
        [JsonInclude]
        public Hoy hoy { get; set; }

    }
    public class Hoy
    {
        [JsonInclude]
        public List<String> temperatura { get; set; }

	}

}
