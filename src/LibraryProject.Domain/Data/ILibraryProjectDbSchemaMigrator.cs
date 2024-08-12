using System.Threading.Tasks;

namespace LibraryProject.Data;

public interface ILibraryProjectDbSchemaMigrator
{
    Task MigrateAsync();
}
