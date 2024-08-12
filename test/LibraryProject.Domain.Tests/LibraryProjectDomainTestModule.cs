using Volo.Abp.Modularity;

namespace LibraryProject;

[DependsOn(
    typeof(LibraryProjectDomainModule),
    typeof(LibraryProjectTestBaseModule)
)]
public class LibraryProjectDomainTestModule : AbpModule
{

}
