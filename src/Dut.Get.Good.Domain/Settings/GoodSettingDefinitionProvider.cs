using Volo.Abp.Settings;

namespace Dut.Get.Good.Settings;

public class GoodSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(GoodSettings.MySetting1));
    }
}
