
using CWS.Service.DTOs;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CWS.Service.People
{
    public class PeopleService : IPeopleService
    {
        private readonly IConfiguration _configuration;
        public PeopleService(IConfiguration iconfiguration)
        {
            _configuration = iconfiguration;
        }
        public async Task<PeopleDTO> GetAllPeoples()
        {
            string Baseurl = "https://swapi.dev/api/";
            PeopleDTO people = new PeopleDTO();
            using (var client = new HttpClient())
            {
                //Passing service base url
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();                
                //Sending request to find web api REST service resource Category List using HttpClient               
                HttpResponseMessage Res = await client.GetAsync("people");
                //Checking the response is successful or not which is sent using HttpClient
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api
                    var responseData = Res.Content.ReadAsStringAsync().Result;
                    people = JsonConvert.DeserializeObject<PeopleDTO>(responseData, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore });
                }
            }
            return people;
        }

        public async Task<PeopleDTO> SearchPeople(string query)
        {
            string Baseurl = "https://swapi.dev/api/";
            PeopleDTO people = new PeopleDTO();
            using (var client = new HttpClient())
            {
                //Passing service base url
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                //Sending request to find web api REST service resource Category List using HttpClient               
                HttpResponseMessage Res = await client.GetAsync("people/?search=" +query);
                //Checking the response is successful or not which is sent using HttpClient
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api
                    var responseData = Res.Content.ReadAsStringAsync().Result;
                    people = JsonConvert.DeserializeObject<PeopleDTO>(responseData, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore });
                }
            }
            return people;
        }
    }
}
