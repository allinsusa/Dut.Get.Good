using Volo.Abp.Modularity;

namespace Dut.Get.Good;

[DependsOn(
    typeof(GoodApplicationModule),
    typeof(GoodDomainTestModule)
    )]
public class GoodApplicationTestModule : AbpModule
{

}
