using AnvuEcommerce.Localization;
 using Volo.Abp.AspNetCore.Mvc;

namespace AnvuEcommerce.Public.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AnvuEcommercePublicController : AbpControllerBase
{
    protected AnvuEcommercePublicController()
    {
        LocalizationResource = typeof(AnvuEcommerceResource);
    }
}
