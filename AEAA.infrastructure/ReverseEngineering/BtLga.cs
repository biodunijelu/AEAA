using System;
using System.Collections.Generic;

namespace AEAA.Infrastructure.ReverseEngineering
{
    public partial class BtLga
    {
        public BtLga()
        {
            TUserExt = new HashSet<TUserExt>();
        }

        public int LgaId { get; set; }
        public string LgaCode { get; set; }
        public string Name { get; set; }
        public string StateCode { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModified { get; set; }
        public string ModifiedBy { get; set; }
        public bool? IsActive { get; set; }

        public virtual BtState StateCodeNavigation { get; set; }
        public virtual ICollection<TUserExt> TUserExt { get; set; }
    }
}
