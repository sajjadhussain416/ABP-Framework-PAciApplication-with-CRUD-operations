using Volo.Abp.Settings;

namespace PaciApplication.Settings;

public class PaciApplicationSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(PaciApplicationSettings.MySetting1));
    }
}
