using System;
using System.Collections.Generic;
using System.Text;
using PaciApplication.Localization;
using Volo.Abp.Application.Services;

namespace PaciApplication;

/* Inherit your application services from this class.
 */
public abstract class PaciApplicationAppService : ApplicationService
{
    protected PaciApplicationAppService()
    {
        LocalizationResource = typeof(PaciApplicationResource);
    }
}
