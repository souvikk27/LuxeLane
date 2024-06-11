using Luxelane.Domain.Migrator;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("Application started.");

var serviceProvider = new ServiceCollection()
    .AddDbContext<LuxelaneContext>(options => options.UseNpgsql("SqlConnection"))
    .BuildServiceProvider();
try
{
    using (var scope = serviceProvider.CreateScope())
    {
        var dbContext = scope.ServiceProvider.GetRequiredService<LuxelaneContext>();

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

