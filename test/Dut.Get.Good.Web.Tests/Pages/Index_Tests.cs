using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Dut.Get.Good.Pages;

public class Index_Tests : GoodWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
