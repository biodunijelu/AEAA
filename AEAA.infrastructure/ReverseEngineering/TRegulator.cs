using System;
using System.Collections.Generic;

namespace AEAA.Infrastructure.ReverseEngineering
{
    public partial class TRegulator
    {
        public long RegId { get; set; }
        public string Name { get; set; }
        public string RegCode { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? LastModified { get; set; }
        public bool? IsActive { get; set; }

        public virtual BtPermissions BtPermissions { get; set; }
    }
}
