using System;
using System.Threading.Tasks;
using LibraryProject.Authors;
using Shouldly;
using Volo.Abp.Modularity;
using Xunit;

namespace LibraryProject.Authors
{
    public abstract class AuthorAppService_Tests<TStartupModule> : LibraryProjectApplicationTestBase<TStartupModule>
        where TStartupModule : IAbpModule
    {
        private readonly IAuthorAppService _authorAppService;

        protected AuthorAppService_Tests()
        {
            _authorAppService = GetRequiredService<IAuthorAppService>();
        }

        [Fact]
        public async Task Should_Get_All_Authors_Without_Any_Filter()
        {
            var result = await _authorAppService.GetListAsync(new GetAuthorListDto());
            result.TotalCount.ShouldBeGreaterThanOrEqualTo(2);
            result.Items.ShouldContain(author => author.Name == "George Orwell");
            result.Items.ShouldContain(author => author.Name == "Douglas Adams");
        }

        [Fact]
        public async Task Should_Get_Filtered_Authors()
        {
            var result = await _authorAppService.GetListAsync(
                new GetAuthorListDto { Filter = "George" });
            result.TotalCount.ShouldBeGreaterThanOrEqualTo(1);
            result.Items.ShouldContain(author => author.Name == "George Orwell");
            result.Items.ShouldNotContain(author => author.Name == "Douglas Adams");
        }

        [Fact]
        public async Task Should_Create_A_New_Author()
        {
            var authorDto = await _authorAppService.CreateAsync(
                new CreateAuthorDto
                {
                    Name = "New Author",
                    BirthDate = new DateTime(1990, 01, 01),
                    ShortBio = "New author biography..."
                }
            );
            authorDto.Id.ShouldNotBe(Guid.Empty);
            authorDto.Name.ShouldBe("New Author");
        }

        [Fact]
        public async Task Should_Not_Allow_To_Create_Duplicate_Author()
        {
            await Assert.ThrowsAsync<AuthorAlreadyExistsException>(async () =>
            {
                await _authorAppService.CreateAsync(
                    new CreateAuthorDto
                    {
                        Name = "Douglas Adams",
                        BirthDate = DateTime.Now,
                        ShortBio = "..."
                    }
                );
            });
        }

        //TODO: Test other methods...
    }
}
