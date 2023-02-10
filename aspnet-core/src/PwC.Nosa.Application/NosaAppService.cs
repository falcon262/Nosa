using PwC.Nosa.Localization;
using Volo.Abp.Application.Services;

namespace PwC.Nosa;

/* Inherit your application services from this class.
 */
public abstract class NosaAppService : ApplicationService
{
    protected NosaAppService()
    {
        LocalizationResource = typeof(NosaResource);
    }
}
