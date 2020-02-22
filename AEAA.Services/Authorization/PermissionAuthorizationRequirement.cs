using Microsoft.AspNetCore.Authorization;
using System;

namespace AEAA.Services.Authorization
{
    public class PermissionAuthorizationRequirement : IAuthorizationRequirement
    {
        public PermissionAuthorizationRequirement(string permissionName)
        {
            PermissionName = permissionName ?? throw new ArgumentNullException(nameof(permissionName)); ;
        }

        public string PermissionName { get; }
    }
}
