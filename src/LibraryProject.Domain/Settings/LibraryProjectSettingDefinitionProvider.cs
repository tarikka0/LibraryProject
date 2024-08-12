using Volo.Abp.Settings;

namespace LibraryProject.Settings;

public class LibraryProjectSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(LibraryProjectSettings.MySetting1));
    }
}
