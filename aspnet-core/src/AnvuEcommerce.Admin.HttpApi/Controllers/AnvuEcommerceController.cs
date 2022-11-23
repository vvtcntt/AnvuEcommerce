using AnvuEcommerce.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AnvuEcommerce.Admin.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AnvuEcommerceController : AbpControllerBase
{
    protected AnvuEcommerceController()
    {
        LocalizationResource = typeof(AnvuEcommerceResource);
    }
}
