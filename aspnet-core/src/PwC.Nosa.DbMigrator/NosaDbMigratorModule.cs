using PwC.Nosa.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace PwC.Nosa.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(NosaEntityFrameworkCoreModule),
    typeof(NosaApplicationContractsModule)
)]
public class NosaDbMigratorModule : AbpModule
{

}
