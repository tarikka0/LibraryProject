using LibraryProject.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace LibraryProject.Permissions;

public class LibraryProjectPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(LibraryProjectPermissions.GroupName);

        var booksPermission = myGroup.AddPermission(LibraryProjectPermissions.Books.Default, L("Permission:Books"));
        booksPermission.AddChild(LibraryProjectPermissions.Books.Create, L("Permission:Books.Create"));
        booksPermission.AddChild(LibraryProjectPermissions.Books.Edit, L("Permission:Books.Edit"));
        booksPermission.AddChild(LibraryProjectPermissions.Books.Delete, L("Permission:Books.Delete"));
        //Define your own permissions here. Example:
        //myGroup.AddPermission(LibraryProjectPermissions.MyPermission1, L("Permission:MyPermission1"));
        var authorsPermission = myGroup.AddPermission(
       LibraryProjectPermissions.Authors.Default, L("Permission:Authors"));
        authorsPermission.AddChild(
            LibraryProjectPermissions.Authors.Create, L("Permission:Authors.Create"));
        authorsPermission.AddChild(
           LibraryProjectPermissions.Authors.Edit, L("Permission:Authors.Edit"));
        authorsPermission.AddChild(
           LibraryProjectPermissions.Authors.Delete, L("Permission:Authors.Delete"));


    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<LibraryProjectResource>(name);
    }
}
