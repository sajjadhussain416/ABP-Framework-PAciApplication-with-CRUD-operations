using PaciApplication.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace PaciApplication.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class PaciApplicationPageModel : AbpPageModel
{
    protected PaciApplicationPageModel()
    {
        LocalizationResourceType = typeof(PaciApplicationResource);
    }
}
