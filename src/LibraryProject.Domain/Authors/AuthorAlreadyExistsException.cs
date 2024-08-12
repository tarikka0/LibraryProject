using LibraryProject;
using Volo.Abp;

namespace LibraryProject.Authors;

public class AuthorAlreadyExistsException : BusinessException
{
    public AuthorAlreadyExistsException(string name)
        : base(LibraryProjectDomainErrorCodes.AuthorAlreadyExists)
    {
        WithData("name", name);
    }
}
