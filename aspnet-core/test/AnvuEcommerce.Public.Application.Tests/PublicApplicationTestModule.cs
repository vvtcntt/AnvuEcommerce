using Volo.Abp.Modularity;

namespace AnvuEcommerce.Public;

[DependsOn(
    typeof(AnvuEcommercePublicApplicationModule),
    typeof(AnvuEcommerceDomainTestModule)
    )]
public class PublicApplicationTestModule : AbpModule
{

}
