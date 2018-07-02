using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using KS.Configuration.Dto;

namespace KS.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : KSAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
