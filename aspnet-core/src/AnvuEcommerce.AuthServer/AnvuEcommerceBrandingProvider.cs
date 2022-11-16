using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace AnvuEcommerce;

[Dependency(ReplaceServices = true)]
public class AnvuEcommerceBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "AnvuEcommerce";
}
