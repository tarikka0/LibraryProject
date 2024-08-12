using LibraryProject.Books;
using Xunit;

namespace LibraryProject.EntityFrameworkCore.Applications.Books;

[Collection(LibraryProjectTestConsts.CollectionDefinitionName)]
public class EfCoreBookAppService_Tests : BookAppService_Tests<LibraryProjectEntityFrameworkCoreTestModule>
{

}