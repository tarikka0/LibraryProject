using Volo.Abp.Modularity;

namespace LibraryProject;

/* Inherit from this class for your domain layer tests. */
public abstract class LibraryProjectDomainTestBase<TStartupModule> : LibraryProjectTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
