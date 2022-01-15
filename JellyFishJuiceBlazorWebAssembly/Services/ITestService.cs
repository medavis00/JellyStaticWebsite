using JellyFishJuiceBlazorWebAssembly.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JellyFishJuiceBlazorWebAssembly.Services
{
    public interface ITestService
    {
        Task<List<TestDTO>> GetTests();
    }
}
