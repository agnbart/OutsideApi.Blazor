using OutsideApi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace OutsideApi.Infostructure.ConnectedServices
{
    public class FreeBookMapService : IFreeBookMapService
    {
        public async Task<List<FreeBookMap>> Retrive()
        {
            using (var client = new HttpClient())
            {
                var result = await client.GetAsync(@"https://wolnelektury.pl/api/books/?format=json");

                return await result.Content.ReadFromJsonAsync<List<FreeBookMap>>();
            }
        }
    }
}
