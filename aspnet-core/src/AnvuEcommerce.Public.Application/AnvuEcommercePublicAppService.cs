using System;
using System.Collections.Generic;
using System.Text;
using AnvuEcommerce.Localization;
 using Volo.Abp.Application.Services;

namespace AnvuEcommerce.Public;

/* Inherit your application services from this class.
 */
public abstract class AnvuEcommercePublicAppService : ApplicationService
{
    protected AnvuEcommercePublicAppService()
    {
        LocalizationResource = typeof(AnvuEcommerceResource);
    }
}
