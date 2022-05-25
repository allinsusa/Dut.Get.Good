using Dut.Get.Good.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Dut.Get.Good.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class GoodPageModel : AbpPageModel
{
    protected GoodPageModel()
    {
        LocalizationResourceType = typeof(GoodResource);
    }
}
