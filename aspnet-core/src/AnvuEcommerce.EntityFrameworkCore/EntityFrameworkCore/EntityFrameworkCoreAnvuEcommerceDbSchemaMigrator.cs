using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AnvuEcommerce.Data;
using Volo.Abp.DependencyInjection;

namespace AnvuEcommerce.EntityFrameworkCore;

public class EntityFrameworkCoreAnvuEcommerceDbSchemaMigrator
    : IAnvuEcommerceDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreAnvuEcommerceDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the AnvuEcommerceDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<AnvuEcommerceDbContext>()
            .Database
            .MigrateAsync();
    }
}
