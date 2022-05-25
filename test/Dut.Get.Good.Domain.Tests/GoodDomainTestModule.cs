using Dut.Get.Good.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Dut.Get.Good;

[DependsOn(
    typeof(GoodEntityFrameworkCoreTestModule)
    )]
public class GoodDomainTestModule : AbpModule
{

}
