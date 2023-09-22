using Volo.Abp.Modularity;

namespace PaciApplication;

[DependsOn(
    typeof(PaciApplicationApplicationModule),
    typeof(PaciApplicationDomainTestModule)
    )]
public class PaciApplicationApplicationTestModule : AbpModule
{

}
