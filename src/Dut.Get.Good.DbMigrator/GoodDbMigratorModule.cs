using Dut.Get.Good.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Dut.Get.Good.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(GoodEntityFrameworkCoreModule),
    typeof(GoodApplicationContractsModule)
    )]
public class GoodDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
