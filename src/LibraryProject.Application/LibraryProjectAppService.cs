using LibraryProject.Localization;
using Volo.Abp.Application.Services;

namespace LibraryProject;

/* Inherit your application services from this class.
 */
public abstract class LibraryProjectAppService : ApplicationService
{
    protected LibraryProjectAppService()
    {
        LocalizationResource = typeof(LibraryProjectResource);
    }
}
