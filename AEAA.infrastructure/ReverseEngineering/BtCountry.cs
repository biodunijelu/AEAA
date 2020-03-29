using System;
using System.Collections.Generic;

namespace AEAA.Infrastructure.ReverseEngineering
{
    public partial class BtCountry
    {
        public BtCountry()
        {
            BtState = new HashSet<BtState>();
            TUserExt = new HashSet<TUserExt>();
        }

        public int CountryId { get; set; }
        public string CountryCode { get; set; }
        public string Name { get; set; }
        public string NationalCurrency { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? LastModified { get; set; }
        public bool? IsActive { get; set; }
        public string Nationality { get; set; }

        public virtual ICollection<BtState> BtState { get; set; }
        public virtual ICollection<TUserExt> TUserExt { get; set; }
    }
}
