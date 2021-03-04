using Volo.Abp.Settings;

namespace WFCore.Settings
{
    public class WFCoreSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(WFCoreSettings.MySetting1));
        }
    }
}
