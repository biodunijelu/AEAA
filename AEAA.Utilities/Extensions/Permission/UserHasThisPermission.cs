using AEAA.Utilities.Enums;
using System.Linq;
using System.Security.Claims;

namespace AEAA.Utilities.Extensions.Permission
{
    public static class UserHasThisPermission
    {
        /// <summary>
        /// This returns true if the current user has the permission
        /// </summary>
        /// <param name="user"></param>
        /// <param name="permission"></param>
        /// <returns></returns>
        public static bool AEAAUserHasThisPermission(this ClaimsPrincipal user, AEAAPermissions permission)
        {
            var permissionClaim =
                user?.Claims.SingleOrDefault(x => x.Type == PermissionConstants.PackedPermissionClaimType);
            return permissionClaim?.Value.UnpackPermissionsFromString().ToArray().UserHasThisPermission(permission) == true;
        }
    }
}
