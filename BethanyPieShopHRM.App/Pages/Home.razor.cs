﻿using BethanyPieShopHRM.App.Components.Widgets;

namespace BethanyPieShopHRM.App.Pages
{
    public partial class Home
    {
        public List<Type> Widgets { get; set; } = new List<Type>() { typeof(EmployeeCountWidget), typeof(InboxWidget) };
    }
}
