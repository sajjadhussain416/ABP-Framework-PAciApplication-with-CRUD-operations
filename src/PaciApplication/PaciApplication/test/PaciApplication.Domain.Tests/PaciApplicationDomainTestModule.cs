using PaciApplication.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace PaciApplication;

[DependsOn(
    typeof(PaciApplicationEntityFrameworkCoreTestModule)
    )]
public class PaciApplicationDomainTestModule : AbpModule
{

}
