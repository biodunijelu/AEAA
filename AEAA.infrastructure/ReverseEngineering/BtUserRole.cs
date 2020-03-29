using System;
using System.Collections.Generic;

namespace AEAA.Infrastructure.ReverseEngineering
{
    public partial class BtUserRole
    {
        public string UserId { get; set; }
        public string RoleId { get; set; }
        public string Discriminator { get; set; }
        public DateTime? LastModified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual BtRoles Role { get; set; }
        public virtual BtUser User { get; set; }
    }
}
