using AEAA.Models.Domains;
using AEAA.Models.Domains.User;
using System.Collections.Generic;

namespace AEAA.Models.Domains.Location
{
    public partial class BtCountry:BaseObject
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
        public string Nationality { get; set; }

        public virtual ICollection<BtState> BtState { get; set; }
       
        public virtual ICollection<TUserExt> TUserExt { get; set; }
    }
}
