using System;
using System.Collections.Generic;
using System.Text;
using AnvuEcommerce.Localization;
using Volo.Abp.Application.Services;

namespace AnvuEcommerce;

/* Inherit your application services from this class.
 */
public abstract class AnvuEcommerceAppService : ApplicationService
{
    protected AnvuEcommerceAppService()
    {
        LocalizationResource = typeof(AnvuEcommerceResource);
    }
}
