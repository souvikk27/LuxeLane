﻿using LuxeLane.Domain.Migrator;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("Application started.");

var serviceProvider = new ServiceCollection()
    .AddDbContext<MigrationContext>(options => options.UseNpgsql("SqlConnection"))
    .BuildServiceProvider();
try
{
    using (var scope = serviceProvider.CreateScope())
    {
        var dbContext = scope.ServiceProvider.GetRequiredService<MigrationContext>();

        // Apply pending migrations
        dbContext.Database.Migrate();
    }
    Console.WriteLine("Migration completed successfully.");
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}
finally
{
    Console.WriteLine("press any key to exit...");
    Console.ReadKey();
}

