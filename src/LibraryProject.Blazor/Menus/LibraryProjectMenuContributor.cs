using System.Threading.Tasks;
using LibraryProject.Localization;
using LibraryProject.Permissions;
using LibraryProject.MultiTenancy;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.UI.Navigation;
using Volo.Abp.SettingManagement.Blazor.Menus;
using Volo.Abp.TenantManagement.Blazor.Navigation;
using Volo.Abp.Identity.Blazor;

namespace LibraryProject.Blazor.Menus
{
    public class LibraryProjectMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenuAsync(context);

            }
        }

        private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
        {
            var l = context.GetLocalizer<LibraryProjectResource>();

            context.Menu.Items.Insert(
                0,
                new ApplicationMenuItem(
                    LibraryProjectMenus.Home,
                    l["Menu:Home"],
                    "/",
                    icon: "fas fa-home",
                    order: 1

                )
            );

            // Administration
            var administration = context.Menu.GetAdministration();
            administration.Order = 4;

            if (MultiTenancyConsts.IsEnabled)
            {
                administration.SetSubItemOrder(TenantManagementMenuNames.GroupName, 1);
            }
            else
            {
                administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
            }

            administration.SetSubItemOrder(IdentityMenuNames.GroupName, 2);
            administration.SetSubItemOrder(SettingManagementMenus.GroupName, 3);

            context.Menu.AddItem(

                new ApplicationMenuItem(
                    "BooksStore",
                    l["Menu:Library"],
                    icon: "fa fa-book"
                ).AddItem(
                    new ApplicationMenuItem(
                        "BooksStore.Books",
                        l["Menu:Books"],
                        url: "/books"
                    ).RequirePermissions(LibraryProjectPermissions.Books.Default)
                ).AddItem(
                    new ApplicationMenuItem(
                        "BooksStore.Readers",
                        l["Menu:Readers"],
                        url: "/readers"
                    )
                ));
            if (await context.IsGrantedAsync(LibraryProjectPermissions.Authors.Default))
            {
                context.Menu.AddItem(new ApplicationMenuItem(
                    "BooksStore.Authors",
                    l["Menu:Authors"],
                    url: "/authors"
                )
                    );
            }

        }




    }
}
    

