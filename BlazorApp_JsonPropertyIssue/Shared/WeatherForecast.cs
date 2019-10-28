using Newtonsoft.Json;
using System;

namespace BlazorApp_JsonPropertyIssue.Shared
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        [JsonProperty("sum")]
        public string Summary { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }
}
