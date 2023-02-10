using PwC.Nosa.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace PwC.Nosa;

[DependsOn(
    typeof(NosaEntityFrameworkCoreTestModule)
    )]
public class NosaDomainTestModule : AbpModule
{

}
