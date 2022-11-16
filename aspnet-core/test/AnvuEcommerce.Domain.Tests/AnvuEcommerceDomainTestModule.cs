using AnvuEcommerce.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AnvuEcommerce;

[DependsOn(
    typeof(AnvuEcommerceEntityFrameworkCoreTestModule)
    )]
public class AnvuEcommerceDomainTestModule : AbpModule
{

}
