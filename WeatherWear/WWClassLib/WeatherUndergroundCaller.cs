using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace WWClassLib
{
    public class WeatherUndergroundCaller
    {
        public WeatherUndergroundCaller()
        {
            //this is the constructor, it is called when the object is created
        }

        public async Task<string> GetForecast(string stateAccronym, string city)
        {
            try
            {
                string path = $"{Constants.WeatherUndergroundForcast}/{stateAccronym}/{city}.json";

                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(
                        new MediaTypeWithQualityHeaderValue("application/json"));
                    using (HttpResponseMessage response = await client.GetAsync(path))  //we are actually making the call here
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            using (HttpContent content = response.Content)
                            {
                                // ... Read the string.
                                string result = await content.ReadAsStringAsync();

                                //TODO: read the result as a forecast obj

                                //return the string
                                return result;
                            }
                        }
                        else
                        {
                            return $"Error {response.ReasonPhrase}";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }

        public async Task<string> GetGeoLookUp(int zip)
        {
            try
            {
                string path = $"{Constants.WeatherUndergroundGeolookup}{zip}.json";

                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(
                        new MediaTypeWithQualityHeaderValue("application/json"));

                    using (HttpResponseMessage response = await client.GetAsync(path))  //we are actually making the call here
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            using (HttpContent content = response.Content)
                            {
                                // ... Read the string.
                                string result = await content.ReadAsStringAsync();

                                //TODO: read the result as a geolookup obj

                                //return the string
                                return result;
                            }
                        }
                        else
                        {
                            return $"Error {response.ReasonPhrase}";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }
    }
}