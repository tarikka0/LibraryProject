using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace LibraryProject.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class LibraryProjectDbContextFactory : IDesignTimeDbContextFactory<LibraryProjectDbContext>
{
    public LibraryProjectDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        LibraryProjectEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<LibraryProjectDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));
        
        return new LibraryProjectDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../LibraryProject.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
