using System;
using System.Collections.Generic;

namespace AEAA.Infrastructure.ReverseEngineering
{
    public partial class BtUser
    {
        public BtUser()
        {
            BtUserClaim = new HashSet<BtUserClaim>();
            BtUserLogin = new HashSet<BtUserLogin>();
            BtUserRole = new HashSet<BtUserRole>();
            TUserExt = new HashSet<TUserExt>();
        }

        public string UserId { get; set; }
        public string UserName { get; set; }
        public string NormalizedUserName { get; set; }
        public string Email { get; set; }
        public string NormalizedEmail { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string ConcurrencyStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTimeOffset? LockoutEnd { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public DateTime? LastModified { get; set; }
        public string Token { get; set; }
        public string RefreshToken { get; set; }
        public DateTime? ExpirationTime { get; set; }
        public DateTimeOffset? LastLoginDate { get; set; }
        public bool HasBranch { get; set; }
        public DateTime PwdExpiryDate { get; set; }
        public bool ForcePwdChange { get; set; }
        public string ModifiedBy { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? PwdChangedDate { get; set; }

        public virtual ICollection<BtUserClaim> BtUserClaim { get; set; }
        public virtual ICollection<BtUserLogin> BtUserLogin { get; set; }
        public virtual ICollection<BtUserRole> BtUserRole { get; set; }
        public virtual ICollection<TUserExt> TUserExt { get; set; }
    }
}
