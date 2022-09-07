using OutsideApi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace OutsideApi.Infostructure.ConnectedServices
{
    public class BitcoinMapService : IBitcoinMapService
    {
        public async Task<BitcoinMap> Retrive()
        {
            using (var client = new HttpClient())
            {
                var result = await client.GetAsync(@"https://api.coinpaprika.com/v1/coins/btc-bitcoin");
                return await result.Content.ReadFromJsonAsync<BitcoinMap>();

            }
        }
    }
}