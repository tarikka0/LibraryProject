using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace LibraryProject.Data;

/* This is used if database provider does't define
 * ILibraryProjectDbSchemaMigrator implementation.
 */
public class NullLibraryProjectDbSchemaMigrator : ILibraryProjectDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
