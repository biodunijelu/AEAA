using System;
using System.Collections.Generic;

namespace AEAA.Infrastructure.ReverseEngineering
{
    public partial class BtUserClaim
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }

        public virtual BtUser User { get; set; }
    }
}
