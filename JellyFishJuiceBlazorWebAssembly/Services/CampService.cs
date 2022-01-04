using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json;
using JellyStaticBlazor.Common.Models;

namespace JellyFishJuiceBlazorWebAssembly.Services
{
    public class CampService : ICampService
    {
        private readonly HttpClient _httpClient;

        public CampService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Camp>> GetCamps()
        {
            return await _httpClient.GetFromJsonAsync<List<Camp>>("api/Camps");
        }
    }
}
