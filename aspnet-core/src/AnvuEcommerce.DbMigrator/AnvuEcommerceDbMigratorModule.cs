using AnvuEcommerce.Admin;
using AnvuEcommerce.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace AnvuEcommerce.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AnvuEcommerceEntityFrameworkCoreModule),
    typeof(AnvuEcommerceApplicationContractsModule)
    )]
public class AnvuEcommerceDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
