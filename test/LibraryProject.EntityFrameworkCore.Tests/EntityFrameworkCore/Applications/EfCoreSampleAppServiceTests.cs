using LibraryProject.Samples;
using Xunit;

namespace LibraryProject.EntityFrameworkCore.Applications;

[Collection(LibraryProjectTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<LibraryProjectEntityFrameworkCoreTestModule>
{

}
