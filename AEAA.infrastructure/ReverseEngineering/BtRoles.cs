using System;
using System.Collections.Generic;

namespace AEAA.Infrastructure.ReverseEngineering
{
    public partial class BtRoles
    {
        public BtRoles()
        {
            BtRoleClaim = new HashSet<BtRoleClaim>();
            BtUserRole = new HashSet<BtUserRole>();
        }

        public string RoleId { get; set; }
        public string RoleName { get; set; }
        public string RoleNameNormalised { get; set; }
        public string ConcurrencyStamp { get; set; }
        public DateTime LastModified { get; set; }
        public string ModifiedBy { get; set; }
        public bool IsSuperUser { get; set; }
        public string RoleDesc { get; set; }
        public bool? IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? MerchantId { get; set; }
        public string CreatedBy { get; set; }
        public string PermissionsInRole { get; set; }

        public virtual ICollection<BtRoleClaim> BtRoleClaim { get; set; }
        public virtual ICollection<BtUserRole> BtUserRole { get; set; }
    }
}
