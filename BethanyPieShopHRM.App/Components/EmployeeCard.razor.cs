using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanyPieShopHRM.App.Components
{
    public partial class EmployeeCard
    {
        [Parameter]
        public Employee Employee { get; set; } = default!;

        [Inject]
        public NavigationManager NavigationManager { get; set; } = default!;

        [Parameter]
        public EventCallback<Employee> EmployeeQuickViewClicked { get; set; }


        public void NavigateToDetails(Employee employee)
        {
            NavigationManager.NavigateTo($"/employeeDetail/{employee.EmployeeId}");
        }
    }
}
