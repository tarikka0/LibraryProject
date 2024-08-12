using AutoMapper;
using LibraryProject.Books;

namespace LibraryProject.Blazor;

public class LibraryProjectBlazorAutoMapperProfile : Profile
{
    public LibraryProjectBlazorAutoMapperProfile()
    {
        CreateMap<BookDto, CreateUpdateBookDto>();
        
        //Define your AutoMapper configuration here for the Blazor project.
    }
}
