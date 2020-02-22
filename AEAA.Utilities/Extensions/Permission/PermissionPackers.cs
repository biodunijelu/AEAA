using AEAA.Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AEAA.Utilities.Extensions.Permission
{
    public static class PermissionPackers
    {
        public static string PackPermissionsIntoString(this IEnumerable<AEAAPermissions> permissions)
        {
            return permissions.Aggregate("", (s, permission) => s + (char)permission);
        }

        public static IEnumerable<AEAAPermissions> UnpackPermissionsFromString(this string packedPermissions)
        {
            if (packedPermissions == null)
                throw new ArgumentNullException(nameof(packedPermissions));
            foreach (var character in packedPermissions)
            {
                yield return ((AEAAPermissions)character);
            }
        }

        public static AEAAPermissions? FindPermissionViaName(this string permissionName)
        {
            return Enum.TryParse(permissionName, out AEAAPermissions permission)
                ? (AEAAPermissions?)permission
                : null;
        }
    }
}
