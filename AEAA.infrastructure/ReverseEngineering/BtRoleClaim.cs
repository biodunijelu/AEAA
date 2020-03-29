using System;
using System.Collections.Generic;

namespace AEAA.Infrastructure.ReverseEngineering
{
    public partial class BtRoleClaim
    {
        public int Id { get; set; }
        public string RoleId { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }

        public virtual BtRoles Role { get; set; }
    }
}
