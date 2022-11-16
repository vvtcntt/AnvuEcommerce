using Volo.Abp.Modularity;

namespace AnvuEcommerce;

[DependsOn(
    typeof(AnvuEcommerceApplicationModule),
    typeof(AnvuEcommerceDomainTestModule)
    )]
public class AnvuEcommerceApplicationTestModule : AbpModule
{

}
