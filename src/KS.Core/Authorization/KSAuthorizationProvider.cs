using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace KS.Authorization
{
    public class KSAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            context.CreatePermission(PermissionNames.Pages_Users, L("Users"));
            context.CreatePermission(PermissionNames.Pages_Roles, L("Roles"));
            context.CreatePermission(PermissionNames.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Host);

            context.CreatePermission(PermissionNames.Pages_Questions, L("Questions"));
            context.CreatePermission(PermissionNames.Pages_Questions_Create, L("QuestionsCreate"));
            context.CreatePermission(PermissionNames.Pages_Questions_Edit, L("QuestionsEdit"));
            context.CreatePermission(PermissionNames.Pages_Questions_Delete, L("QuestionsDelete"));
            context.CreatePermission(PermissionNames.Pages_Questions_Rating, L("QuestionsRating"));
            context.CreatePermission(PermissionNames.Pages_Questions_Comment, L("QuestionsComment"));
            context.CreatePermission(PermissionNames.Pages_Questions_Archive, L("QuestionsArchive"));

            context.CreatePermission(PermissionNames.Pages_Reports, L("Reports"));
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, KSConsts.LocalizationSourceName);
        }
    }
}
