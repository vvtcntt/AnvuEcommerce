using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AnvuEcommerce.Data;

/* This is used if database provider does't define
 * IAnvuEcommerceDbSchemaMigrator implementation.
 */
public class NullAnvuEcommerceDbSchemaMigrator : IAnvuEcommerceDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
