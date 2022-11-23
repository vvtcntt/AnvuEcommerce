using Volo.Abp.Modularity;

namespace AnvuEcommerce.Admin;

[DependsOn(
    typeof(AnvuEcommerceAdminApplicationModule),
    typeof(AnvuEcommerceDomainTestModule)
    )]
public class AnvuEcommerceAdminApplicationTestModule : AbpModule
{

}
