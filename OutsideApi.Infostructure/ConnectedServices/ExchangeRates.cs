using OutsideApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace OutsideApi.Infostructure.ConnectedServices
{
    public class ExchangeRates : IExchangeRates
    {
        private string results = "100";
        public async Task<Currency> Retrive(string currency, string numberOfResults)
        {
            using (var client = new HttpClient())
            {
                var result = await client
                    .GetAsync($@"http://api.nbp.pl/api/exchangerates/rates/a/{currency}/last/{numberOfResults}/?format=json");

                if (result is null) throw new Exception("No data.");

                return await result.Content.ReadFromJsonAsync<Currency>();

            }
        }
    }
}
