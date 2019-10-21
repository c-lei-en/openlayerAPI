﻿using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using openlayerAPI.Configuration.Dto;

namespace openlayerAPI.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : openlayerAPIAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
