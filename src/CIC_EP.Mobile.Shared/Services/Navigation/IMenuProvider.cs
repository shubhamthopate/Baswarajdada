using System.Collections.Generic;
using MvvmHelpers;
using CIC_EP.Models.NavigationMenu;

namespace CIC_EP.Services.Navigation
{
    public interface IMenuProvider
    {
        ObservableRangeCollection<NavigationMenuItem> GetAuthorizedMenuItems(Dictionary<string, string> grantedPermissions);
    }
}