using OutsideApi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace OutsideApi.Infostructure.ConnectedServices
{
    public class OpenWeatherMapService : IOpenWeatherMapService
    {
        private const string CelsiusUnit = "metric";
        public async Task<OpenWeatherMap> Retrive(string location, string appId)
        {
            using (var client = new HttpClient())
            {
                var result = await client
                    .GetAsync($@"https://api.openweathermap.org/data/2.5/weather?q={location}&units={CelsiusUnit}&APPID={appId}");

                return await result.Content.ReadFromJsonAsync<OpenWeatherMap>();
            }
        }
    }
}