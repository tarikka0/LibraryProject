using Volo.Abp.Application.Dtos;

namespace LibraryProject.Authors;

public class GetAuthorListDto : PagedAndSortedResultRequestDto
{
    public string? Filter { get; set; }
}
