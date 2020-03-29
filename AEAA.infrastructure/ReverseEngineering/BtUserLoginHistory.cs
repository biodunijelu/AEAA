using System;
using System.Collections.Generic;

namespace AEAA.Infrastructure.ReverseEngineering
{
    public partial class BtUserLoginHistory
    {
        public string LoginhistId { get; set; }
        public string UserId { get; set; }
        public string IpAddress { get; set; }
        public long TenantId { get; set; }
        public DateTime SessionDate { get; set; }
        public string Operation { get; set; }
        public string Browser { get; set; }
    }
}
