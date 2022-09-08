using OutsideApi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace OutsideApi.Infostructure.ConnectedServices
{
    public class BooksOfAuthorService : IBooksOfAuthorService
    {
        public async Task<List<BooksOfAuthorMap>> Retrive()
        {
            using (var client = new HttpClient())
            {
                var result = await client.GetAsync(@"https://wolnelektury.pl/api/authors/adam-mickiewicz/kinds/liryka/books/");

                return await result.Content.ReadFromJsonAsync<List<BooksOfAuthorMap>>();
            }
        }
    }
}
