using Xunit;

namespace LibraryProject.EntityFrameworkCore;

[CollectionDefinition(LibraryProjectTestConsts.CollectionDefinitionName)]
public class LibraryProjectEntityFrameworkCoreCollection : ICollectionFixture<LibraryProjectEntityFrameworkCoreFixture>
{

}
