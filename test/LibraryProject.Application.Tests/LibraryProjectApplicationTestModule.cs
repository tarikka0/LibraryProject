using Volo.Abp.Modularity;

namespace LibraryProject;

[DependsOn(
    typeof(LibraryProjectApplicationModule),
    typeof(LibraryProjectDomainTestModule)
)]
public class LibraryProjectApplicationTestModule : AbpModule
{

}
