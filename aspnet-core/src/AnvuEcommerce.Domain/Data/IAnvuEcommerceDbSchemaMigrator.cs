using System.Threading.Tasks;

namespace AnvuEcommerce.Data;

public interface IAnvuEcommerceDbSchemaMigrator
{
    Task MigrateAsync();
}
