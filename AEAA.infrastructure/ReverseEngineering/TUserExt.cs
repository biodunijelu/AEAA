using System;
using System.Collections.Generic;

namespace AEAA.Infrastructure.ReverseEngineering
{
    public partial class TUserExt
    {
        public long UserextId { get; set; }
        public string GsuserId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Middlename { get; set; }
        public int? CountryId { get; set; }
        public int? StateId { get; set; }
        public int? LgaId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? LastModified { get; set; }
        public bool? IsActive { get; set; }
        public string UserCategory { get; set; }

        public virtual BtCountry Country { get; set; }
        public virtual BtUser Gsuser { get; set; }
        public virtual BtLga Lga { get; set; }
        public virtual BtState State { get; set; }
    }
}
