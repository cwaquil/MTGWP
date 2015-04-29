using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using MTGWindowsPhone.Entidades;

namespace MTGWindowsPhone.Controles
{
    public class DownloadInfoControle2
    {
        public DownloadInfoControle2()
        {

        }



        public async void getCard()
        {
            using (HttpClient client = new HttpClient())
            {
                // pbWeather.Visibility = System.Windows.Visibility.Visible;
                client.BaseAddress = new Uri("http://api.mtgdb.info");

                //var url = "data/2.5/forecast/daily?q={0}&mode=json&units=metric&cnt=7";

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync("cards");

                Console.WriteLine(response.StatusCode);

                if (response.IsSuccessStatusCode)
                {
                    var data = response.Content.ReadAsStringAsync();
                    List<RootObject> deserializedData = JsonConvert.DeserializeObject<List<RootObject>>(data.Result.ToString());

                    foreach (RootObject ro in deserializedData)
                    {
                        Console.WriteLine(ro.name);
                    }

                }
            }
        }

    }
}
