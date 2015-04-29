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

        public async Task<List<Card>> getFilteredCards(String name, String type, String subtype, List<String> colors, String power, String toughness, String cmc)
        {
            using (HttpClient client = new HttpClient())
            {
                List<Card> deserializedData = new List<Card>();
                try
                {
                    client.BaseAddress = new Uri("http://api.mtgdb.info");
                    StringBuilder sb = new StringBuilder();
                    sb.Append("search/?q=");
                    sb.Append("name m '" + name + "' ");
                    sb.Append("and type m '" + type + "' ");
                    sb.Append("and subtype m '" + subtype + "' ");
                    foreach (String color in colors)
                    {
                        sb.Append("and color m " + color + " ");
                    }
                    if (!"".Equals(power))
                    {
                        sb.Append("and power eq " + power + " ");
                    }

                    if (!"".Equals(toughness))
                    {
                        sb.Append("and toughness eq " + toughness + " ");
                    }

                    if (!"".Equals(cmc))
                    {
                        sb.Append("and color eq " + cmc + " ");
                    }

                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage response = await client.GetAsync(sb.ToString());

                    if (response.IsSuccessStatusCode)
                    {
                        var data = response.Content.ReadAsStringAsync();
                        deserializedData = JsonConvert.DeserializeObject<List<Card>>(data.Result.ToString());
                        foreach (Card ro in deserializedData)
                        {
                            System.Diagnostics.Debug.WriteLine(ro.name);
                        }
                    }
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e.Message);
                }
                return deserializedData;
            }
        }


        public async void getCard()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri("http://api.mtgdb.info");

                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage response = await client.GetAsync("search/lotus?start=0&limit=0");

                    if (response.IsSuccessStatusCode)
                    {
                        var data = response.Content.ReadAsStringAsync();
                        List<Card> deserializedData = JsonConvert.DeserializeObject<List<Card>>(data.Result.ToString());

                        foreach (Card ro in deserializedData)
                        {
                            System.Diagnostics.Debug.WriteLine(ro.name);
                        }

                    }
                }
                catch (Exception e)
                {
                    Console.Write(e.Message);
                }

            }
        }

    }
}
