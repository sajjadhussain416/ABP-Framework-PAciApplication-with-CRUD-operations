using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace PaciApplication.Web;

[Dependency(ReplaceServices = true)]
public class PaciApplicationBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "PaciApplication";
}
