﻿using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JellyFishJuiceBlazorWebAssembly.Services
{
    public class EmployeeOverviewBase : ComponentBase
    {
        [Inject]
        public IEmployeeDataService EmployeeDataService { get; set; }

        //[Inject]
        //public ILogger<EmployeeOverviewBase> Logger { get; set; }

        public List<Employee> Employees { get; set; }

        //protected AddEmployeeDialog AddEmployeeDialog { get; set; }

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
            Employees = (await EmployeeDataService.GetAllEmployees()).ToList();
        }

        public async void AddEmployeeDialog_OnDialogClose()
        {
            Employees = (await EmployeeDataService.GetAllEmployees()).ToList();
            StateHasChanged();
        }

        //protected void QuickAddEmployee()
        //{
        //    AddEmployeeDialog.Show();
        //}
    }
}
