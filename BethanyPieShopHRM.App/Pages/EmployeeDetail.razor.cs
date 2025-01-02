using BethanysPieShopHRM.App.Models;
using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanyPieShopHRM.App.Pages
{
    public partial class EmployeeDetail
    {
        [Parameter]
        public string EmployeeId { get; set; }

        public Employee? Employee { get; set; } = new Employee();

        protected override Task OnInitializedAsync()
        {
            Employee = MockDataService.Employees.FirstOrDefault(e => e.EmployeeId == Convert.ToInt32(EmployeeId));

            return base.OnInitializedAsync();
        }
    }
}
