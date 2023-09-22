using PaciApplication.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace PaciApplication.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(PaciApplicationEntityFrameworkCoreModule),
    typeof(PaciApplicationApplicationContractsModule)
    )]
public class PaciApplicationDbMigratorModule : AbpModule
{
}
