using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace TreeMis.Controllers
{
    public abstract class TreeMisControllerBase: AbpController
    {
        protected TreeMisControllerBase()
        {
            LocalizationSourceName = TreeMisConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
