using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using PaciApplication.Localization;
using PaciApplication.MultiTenancy;
using PACIModel.Models;
using Volo.Abp.Identity.Web.Navigation;
using Volo.Abp.SettingManagement.Web.Navigation;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace PaciApplication.Web.Menus;

public class PaciApplicationMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        var administration = context.Menu.GetAdministration();
        var l = context.GetLocalizer<PaciApplicationResource>();

        context.Menu.Items.Insert(
            0,
            new ApplicationMenuItem(
                PaciApplicationMenus.Home,
                l["Menu:Home"],
                "~/",
                icon: "fas fa-home",
                order: 0
            )
        );

        context.Menu.Items.Insert(
            1,
            new ApplicationMenuItem(
                PaciApplicationMenus.PaciApplication,
                l["PaciApplication"],
                "~/ShowPaciApplication",
                icon: "fab fa-artstation",
                order: 1
            )
        );
        context.Menu.Items.Insert(
            2,
            new ApplicationMenuItem(
                PaciApplicationMenus.PaciSetting,
                  
                   l["PaciSettings"],
                "~/PaciSetting",
                icon: "fab fa-accusoft",
                order: 2
            )
        );


        if (MultiTenancyConsts.IsEnabled)
        {
            administration.SetSubItemOrder(TenantManagementMenuNames.GroupName, 1);
        }
        else
        {
            administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
        }

        administration.SetSubItemOrder(IdentityMenuNames.GroupName, 2);
        administration.SetSubItemOrder(SettingManagementMenuNames.GroupName, 3);

        return Task.CompletedTask;
    }
}
