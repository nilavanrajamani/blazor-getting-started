using Microsoft.AspNetCore.Components;

namespace BethanyPieShopHRM.App.Components
{
    public partial class ProfilePicture
    {
        [Parameter]
        public RenderFragment? ChildContent { get; set; }
    }
}
