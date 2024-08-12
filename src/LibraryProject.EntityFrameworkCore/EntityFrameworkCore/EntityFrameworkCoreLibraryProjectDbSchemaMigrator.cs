using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using LibraryProject.Data;
using Volo.Abp.DependencyInjection;

namespace LibraryProject.EntityFrameworkCore;

public class EntityFrameworkCoreLibraryProjectDbSchemaMigrator
    : ILibraryProjectDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreLibraryProjectDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the LibraryProjectDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<LibraryProjectDbContext>()
            .Database
            .MigrateAsync();
    }
}
