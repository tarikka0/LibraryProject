using Volo.Abp.Account;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.SettingManagement;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.TenantManagement;

namespace LibraryProject;

[DependsOn(
    typeof(LibraryProjectDomainSharedModule),
   
    typeof(AbpSettingManagementApplicationContractsModule),
    typeof(AbpIdentityApplicationContractsModule),
    typeof(AbpAccountApplicationContractsModule),
    typeof(AbpTenantManagementApplicationContractsModule),
    typeof(AbpPermissionManagementApplicationContractsModule)
)]
public class LibraryProjectApplicationContractsModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        LibraryProjectDtoExtensions.Configure();
    }
}
