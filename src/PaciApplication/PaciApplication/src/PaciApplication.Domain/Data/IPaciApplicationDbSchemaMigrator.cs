using System.Threading.Tasks;

namespace PaciApplication.Data;

public interface IPaciApplicationDbSchemaMigrator
{
    Task MigrateAsync();
}
