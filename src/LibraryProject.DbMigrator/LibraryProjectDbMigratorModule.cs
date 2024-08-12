using LibraryProject.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace LibraryProject.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(LibraryProjectEntityFrameworkCoreModule),
    typeof(LibraryProjectApplicationContractsModule)
)]
public class LibraryProjectDbMigratorModule : AbpModule
{
}
