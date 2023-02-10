using Volo.Abp.Modularity;

namespace PwC.Nosa;

[DependsOn(
    typeof(NosaApplicationModule),
    typeof(NosaDomainTestModule)
    )]
public class NosaApplicationTestModule : AbpModule
{

}
