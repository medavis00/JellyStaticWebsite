using JellyStaticBlazor.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JellyFishJuiceBlazorWebAssembly.Services
{
    public interface ICampDataService
    {
        Task<IEnumerable<Camp>> GetAllCamps();
    }
}
