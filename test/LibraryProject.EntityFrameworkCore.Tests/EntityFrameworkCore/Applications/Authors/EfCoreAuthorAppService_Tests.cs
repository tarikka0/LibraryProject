
using LibraryProject.Authors;
using Xunit;

namespace LibraryProject.EntityFrameworkCore.Applications.Authors;

[Collection(LibraryProjectTestConsts.CollectionDefinitionName)]
public class EfCoreAuthorAppService_Tests : AuthorAppService_Tests<LibraryProjectEntityFrameworkCoreTestModule>
{

}
