using AEAA.Models.Domains.Account;
using AEAA.Models.Domains.Location;
using System.Collections.Generic;

namespace AEAA.Models.Domains.User
{
    public partial class TUserExt : BaseObject
    {
        public TUserExt()
        {
            
            //TConferenceRegistration = new HashSet<TConferenceRegistration>();
        }

        public long UserextId { get; set; }
        public string GsuserId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Middlename { get; set; }
        public int? CountryId { get; set; }
        public int? StateId { get; set; }
        public int? LgaId { get; set; }
        public string UserCategory { get; set; }
        public virtual BtCountry Country { get; set; }
        public virtual BtUser Gsuser { get; set; }
     
    }
}
