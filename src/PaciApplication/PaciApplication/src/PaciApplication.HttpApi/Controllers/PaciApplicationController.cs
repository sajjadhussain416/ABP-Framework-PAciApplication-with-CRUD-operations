using PaciApplication.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace PaciApplication.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class PaciApplicationController : AbpControllerBase
{
    protected PaciApplicationController()
    {
        LocalizationResource = typeof(PaciApplicationResource);
    }
}
