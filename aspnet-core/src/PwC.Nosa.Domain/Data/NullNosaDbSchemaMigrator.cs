using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace PwC.Nosa.Data;

/* This is used if database provider does't define
 * INosaDbSchemaMigrator implementation.
 */
public class NullNosaDbSchemaMigrator : INosaDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
