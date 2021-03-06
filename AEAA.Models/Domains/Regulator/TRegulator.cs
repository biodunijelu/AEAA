﻿using AEAA.Models.Domains;
using AEAA.Models.Domains.Account;

namespace AEAA.Models.Domains.Regulator
{
    public partial class TRegulator : BaseObject
    {
        public long RegId { get; set; }
        public string Name { get; set; }
        public string RegCode { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

        public virtual BtPermissions BtPermissions { get; set; }
    }
}
