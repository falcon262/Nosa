using Volo.Abp.Settings;

namespace PwC.Nosa.Settings;

public class NosaSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(NosaSettings.MySetting1));
    }
}
