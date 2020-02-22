using AEAA.Models.Domains;
using AEAA.Models.Domains.User;
using System.Collections.Generic;

namespace AEAA.Models.Domains.Location
{
    public partial class BtState : BaseObject
    {
        public BtState()
        {
            BtLga = new HashSet<BtLga>();
        
            TUserExt = new HashSet<TUserExt>();
        }

        public int StateId { get; set; }
        public string StateCode { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }

        public virtual BtCountry Country { get; set; }
        public virtual ICollection<BtLga> BtLga { get; set; }
      
        public virtual ICollection<TUserExt> TUserExt { get; set; }
    }
}
