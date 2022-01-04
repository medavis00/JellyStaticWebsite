using JellyStaticBlazor.Common.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JellyFishJuiceBlazorWebAssembly.Services
{
    public class CampOverviewBase : ComponentBase
    {
        [Inject]
        public ICampDataService CampDataService { get; set; }

        public List<Camp> Camps { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                throw new Exception("blah");
            }
            catch (Exception e)
            {
                //Logger.LogError("that wasn't good", e);
            }
            Camps = (await CampDataService.GetAllCamps()).ToList();
        }

        public async void AddCampDialog_OnDialogClose()
        {
            Camps = (await CampDataService.GetAllCamps()).ToList();
            StateHasChanged();
        }

    }
}
