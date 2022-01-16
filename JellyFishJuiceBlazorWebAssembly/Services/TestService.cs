using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json;
using JellyFishJuiceBlazorWebAssembly.Controllers;

namespace JellyFishJuiceBlazorWebAssembly.Services
{
    public class TestService : ITestService
    {
        private readonly HttpClient _httpClient;

        public TestService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<TestDTO>> GetTests()
        {

            //try
            //{
                // call the rest api
                return await _httpClient.GetFromJsonAsync<List<TestDTO>>("api/test");
            //}

            //catch (RestClientException e)
            //{
            //    //process exception
            //    if (e instanceof HttpStatusCodeException){
            //        String responseText = ((HttpStatusCodeException)e).getResponseBodyAsString();
            //        //now you have the response, construct json from it, and extract the errors
            //        System.out.println("Exception :" + responseText);
            //    }

            //}

        }
    }



}


