using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace openlayerAPI.Controllers
{
    public abstract class openlayerAPIControllerBase: AbpController
    {
        protected openlayerAPIControllerBase()
        {
            LocalizationSourceName = openlayerAPIConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
