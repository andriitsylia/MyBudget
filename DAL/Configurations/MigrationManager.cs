using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace DAL.Configurations
{
    public static class MigrationManager
    {
        public static IHost MigrateDatabase(this IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                using (var myBudgetContext = scope.ServiceProvider.GetRequiredService<EF.MyBudgetContext>())
                {
                    try
                    {
                        myBudgetContext.Database.Migrate();
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
            return host;
        }
    }
}
