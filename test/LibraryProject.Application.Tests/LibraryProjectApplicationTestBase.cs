using Volo.Abp.Modularity;

namespace LibraryProject;

public abstract class LibraryProjectApplicationTestBase<TStartupModule> : LibraryProjectTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
