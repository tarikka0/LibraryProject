using System;
using Volo.Abp.Application.Dtos;

namespace LibraryProject.Books;

public class AuthorLookupDto : EntityDto<Guid>
{
    public string Name { get; set; }
}
