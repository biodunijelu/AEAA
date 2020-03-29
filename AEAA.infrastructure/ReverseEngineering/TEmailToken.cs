using System;
using System.Collections.Generic;

namespace AEAA.Infrastructure.ReverseEngineering
{
    public partial class TEmailToken
    {
        public int EmailtokenId { get; set; }
        public string EmailToken { get; set; }
        public string PreviewName { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? LastModified { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
    }
}
