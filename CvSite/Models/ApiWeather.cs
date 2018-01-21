using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CvSite.Models
{
    public class ApiWeather
    {
        private static HttpClient client = new HttpClient();

        [HttpGet("[action]/{city}")]
        public async Task<OpenWeatherResponse> GetCity(int idCCity)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri("http://api.openweathermap.org");
                    var response = await client.GetAsync($"/data/2.5/weather?id={idCCity}&appid=c9c459bfcf928cafbf6e6bc71bf2e468&units=metric&lang=fr");
                    response.EnsureSuccessStatusCode();

                    string stringResult = await response.Content.ReadAsStringAsync();

                    OpenWeatherResponse rawWeather = JsonConvert.DeserializeObject<OpenWeatherResponse>(stringResult);
                    return rawWeather;
                }
                catch (HttpRequestException httpRequestException)
                {
                    throw new HttpRequestException(httpRequestException.Message);
                    //return BadRequest($"Error getting weather from OpenWeather: {httpRequestException.Message}");
                }
            }
        }
    }
}