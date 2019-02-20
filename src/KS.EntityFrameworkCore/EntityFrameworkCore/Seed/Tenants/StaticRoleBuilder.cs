using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Abp.Authorization;
using Abp.Authorization.Roles;
using Abp.Authorization.Users;
using Abp.MultiTenancy;
using KS.Authorization;
using KS.Authorization.Roles;
using KS.Authorization.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace KS.EntityFrameworkCore.Seed.Tenants
{
    public  class StaticRoleBuilder
    {

        public static void BuildUserRole(KSDbContext context, int tenantId)
        {
            // User role

            var userRole = context.Roles.IgnoreQueryFilters().FirstOrDefault(r => r.TenantId == tenantId && r.Name == StaticRoleNames.Tenants.User);
            if (userRole == null)
            {
                userRole = context.Roles
                    .Add(new Role(tenantId, StaticRoleNames.Tenants.User, StaticRoleNames.Tenants.User)
                        {IsStatic = true, IsDefault = true}).Entity;
                context.SaveChanges();
            }

            // Grant permissions to user role

            var grantedPermissions = context.Permissions.IgnoreQueryFilters()
                .OfType<RolePermissionSetting>()
                .Where(p => p.TenantId == tenantId && p.RoleId == userRole.Id)
                .Select(p => p.Name)
                .ToList();

            var permissions = PermissionFinder
                .GetAllPermissions(new KSAuthorizationProvider())
                .Where(p => p.MultiTenancySides.HasFlag(MultiTenancySides.Tenant) &&
                            !grantedPermissions.Contains(p.Name) &&
                            p.Name != PermissionNames.Pages_Tenants &&
                            p.Name != PermissionNames.Pages_Users &&
                            p.Name != PermissionNames.Pages_Roles)
                .ToList();

            if (permissions.Any())
            {
                context.Permissions.AddRange(
                    permissions.Select(permission => new RolePermissionSetting
                    {
                        TenantId = tenantId,
                        Name = permission.Name,
                        IsGranted = true,
                        RoleId = userRole.Id
                    })
                );
                context.SaveChanges();
            }           

        }
    }
}
