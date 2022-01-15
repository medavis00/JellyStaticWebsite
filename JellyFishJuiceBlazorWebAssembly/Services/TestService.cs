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
            return await _httpClient.GetFromJsonAsync<List<TestDTO>>("api/test");
        }
    }



}


