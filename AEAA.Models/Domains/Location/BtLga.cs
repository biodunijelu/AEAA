using AEAA.Models.Domains.User;
using System.Collections.Generic;

namespace AEAA.Models.Domains.Location
{
    public partial class BtLga : BaseObject
    {
        public BtLga()
        {
          
            TUserExt = new HashSet<TUserExt>();
        }

        public int LgaId { get; set; }
        public string LgaCode { get; set; }
        public string Name { get; set; }
        public string StateCode { get; set; }

        public virtual BtState StateCodeNavigation { get; set; }
       
        public virtual ICollection<TUserExt> TUserExt { get; set; }
    }
}
