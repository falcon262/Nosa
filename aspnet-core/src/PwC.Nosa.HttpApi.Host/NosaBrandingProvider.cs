using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace PwC.Nosa;

[Dependency(ReplaceServices = true)]
public class NosaBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Nosa";
}
