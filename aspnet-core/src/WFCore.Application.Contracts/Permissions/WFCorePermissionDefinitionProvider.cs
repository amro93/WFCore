using WFCore.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace WFCore.Permissions
{
    public class WFCorePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(WFCorePermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(WFCorePermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<WFCoreResource>(name);
        }
    }
}
