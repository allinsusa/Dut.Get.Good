using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Dut.Get.Good.Web;

[Dependency(ReplaceServices = true)]
public class GoodBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Good";
}
