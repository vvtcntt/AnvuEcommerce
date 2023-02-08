using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace AnvuEcommerce.Public.Web;

[Dependency(ReplaceServices = true)]
public class AnvuEcommercePublicBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Public";
}
