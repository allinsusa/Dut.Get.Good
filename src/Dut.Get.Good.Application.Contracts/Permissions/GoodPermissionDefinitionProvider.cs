using Dut.Get.Good.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Dut.Get.Good.Permissions;

public class GoodPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(GoodPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(GoodPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<GoodResource>(name);
    }
}
