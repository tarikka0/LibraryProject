using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace LibraryProject.Blazor;

[Dependency(ReplaceServices = true)]
public class LibraryProjectBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "LibraryProject";
}
