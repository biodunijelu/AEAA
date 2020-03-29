using System;
using System.Collections.Generic;

namespace AEAA.Infrastructure.ReverseEngineering
{
    public partial class BtState
    {
        public BtState()
        {
            BtLga = new HashSet<BtLga>();
            TUserExt = new HashSet<TUserExt>();
        }

        public int StateId { get; set; }
        public string StateCode { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModified { get; set; }
        public string ModifiedBy { get; set; }
        public int CountryId { get; set; }
        public bool? IsActive { get; set; }

        public virtual BtCountry Country { get; set; }
        public virtual ICollection<BtLga> BtLga { get; set; }
        public virtual ICollection<TUserExt> TUserExt { get; set; }
    }
}
