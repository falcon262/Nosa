using System.Threading.Tasks;

namespace PwC.Nosa.Data;

public interface INosaDbSchemaMigrator
{
    Task MigrateAsync();
}
