using AEAA.Utilities.Enums;
using Microsoft.AspNetCore.Authorization;
using System;

namespace AEAA.Utilities.Extensions.Permission
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, Inherited = false)]
    public class HasPermissionAttribute : AuthorizeAttribute
    {
        public HasPermissionAttribute(AEAAPermissions permission) : base(permission.ToString())
        { }
    }
}
