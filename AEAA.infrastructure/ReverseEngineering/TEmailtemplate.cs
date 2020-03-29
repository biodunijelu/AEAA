using System;
using System.Collections.Generic;

namespace AEAA.Infrastructure.ReverseEngineering
{
    public partial class TEmailtemplate
    {
        public int EtemplateId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public bool? IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? LastModified { get; set; }
    }
}
