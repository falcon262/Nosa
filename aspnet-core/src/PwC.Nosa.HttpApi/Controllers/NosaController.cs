using PwC.Nosa.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace PwC.Nosa.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class NosaController : AbpControllerBase
{
    protected NosaController()
    {
        LocalizationResource = typeof(NosaResource);
    }
}
