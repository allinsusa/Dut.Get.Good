using System;
using System.Collections.Generic;
using System.Text;
using Dut.Get.Good.Localization;
using Volo.Abp.Application.Services;

namespace Dut.Get.Good;

/* Inherit your application services from this class.
 */
public abstract class GoodAppService : ApplicationService
{
    protected GoodAppService()
    {
        LocalizationResource = typeof(GoodResource);
    }
}
