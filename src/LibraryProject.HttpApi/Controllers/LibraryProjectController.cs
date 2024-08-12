using LibraryProject.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace LibraryProject.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class LibraryProjectController : AbpControllerBase
{
    protected LibraryProjectController()
    {
        LocalizationResource = typeof(LibraryProjectResource);
    }
}
