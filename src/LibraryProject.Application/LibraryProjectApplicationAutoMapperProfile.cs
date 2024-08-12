using AutoMapper;
using LibraryProject.Authors;
using LibraryProject.Books;
namespace LibraryProject;

public class LibraryProjectApplicationAutoMapperProfile : Profile
{
    public LibraryProjectApplicationAutoMapperProfile()
    {
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();
        CreateMap<Author, AuthorDto>();
        CreateMap<AuthorDto, UpdateAuthorDto>();
        CreateMap<Author, AuthorLookupDto>();



        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
