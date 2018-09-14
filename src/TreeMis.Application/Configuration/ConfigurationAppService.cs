using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using TreeMis.Configuration.Dto;

namespace TreeMis.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : TreeMisAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
