using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace PaciApplication.Data;

/* This is used if database provider does't define
 * IPaciApplicationDbSchemaMigrator implementation.
 */
public class NullPaciApplicationDbSchemaMigrator : IPaciApplicationDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
