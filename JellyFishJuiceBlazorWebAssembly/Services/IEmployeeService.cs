using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JellyFishJuiceBlazorWebAssembly.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetEmployee();
    }
}
