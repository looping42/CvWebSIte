using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CvSite.Models
{
    public class ApiGoogleNews
    {
        private static HttpClient client = new HttpClient();

        [HttpGet("[action]/{news}")]
        public async Task<GoogleNews> GetNews()
        {
            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri("https://newsapi.org/v2/");
                    //var response = await client.GetAsync($"top-headlines?country=fr&category=technology&apiKey=543183c2078142db9acf5c56463498ec");
                    var response = await client.GetAsync($"top-headlines?country=fr&category=technology&apiKey=543183c2078142db9acf5c56463498ec");

                    response.EnsureSuccessStatusCode();

                    string stringResult = await response.Content.ReadAsStringAsync();

                    GoogleNews googleNews = JsonConvert.DeserializeObject<GoogleNews>(stringResult);
                    return googleNews;
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