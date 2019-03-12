using System;
using System.Collections.Generic;
using System.Text;

using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;

namespace SSHAplicacion
{
    class UserManager
    {
        const String URL = "http://prueb.website/Arduino/myjson.php";
        private HttpClient getCliente()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept","SHHAplicacion/json");
            client.DefaultRequestHeaders.Add("Connection", "close");
            return client;
        }
        public async Task<IEnumerable<user>> getUsuarios()
        {
            HttpClient client = getCliente();
            var res = await client.GetAsync(URL);
            if (res.IsSuccessStatusCode)
            {
                string content = await res.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<IEnumerable<user>>(content);
            }
            return Enumerable.Empty<user>();
        }
    }
}
