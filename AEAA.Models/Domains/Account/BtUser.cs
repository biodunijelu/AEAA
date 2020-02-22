using AEAA.Models.Domains.User;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace AEAA.Models.Domains.Account
{
    public class BtUser : IdentityUser
    {
        public BtUser()
        {
            TUserExt = new HashSet<TUserExt>();
        }
        public string Token { get; set; }
        public string RefreshToken { get; set; }
        public DateTime? ExpirationTime { get; set; }
        public DateTimeOffset? LastLoginDate { get; set; }
        public bool HasBranch { get; set; }
        public DateTime PwdExpiryDate { get; set; }
        public DateTime? PwdChangedDate { get; set; }
        public bool ForcePwdChange { get; set; }
        public DateTime? LastModified { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public virtual ICollection<TUserExt> TUserExt { get; set; }
    }
}
