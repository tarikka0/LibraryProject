using LibraryProject.Samples;
using Xunit;

namespace LibraryProject.EntityFrameworkCore.Domains;

[Collection(LibraryProjectTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<LibraryProjectEntityFrameworkCoreTestModule>
{

}
