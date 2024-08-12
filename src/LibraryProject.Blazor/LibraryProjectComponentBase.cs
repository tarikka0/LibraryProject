using LibraryProject.Localization;
using Volo.Abp.AspNetCore.Components;

namespace LibraryProject.Blazor;

public abstract class LibraryProjectComponentBase : AbpComponentBase
{
    protected LibraryProjectComponentBase()
    {
        LocalizationResource = typeof(LibraryProjectResource);
    }
}
