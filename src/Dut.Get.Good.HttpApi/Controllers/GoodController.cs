using Dut.Get.Good.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Dut.Get.Good.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class GoodController : AbpControllerBase
{
    protected GoodController()
    {
        LocalizationResource = typeof(GoodResource);
    }
}
