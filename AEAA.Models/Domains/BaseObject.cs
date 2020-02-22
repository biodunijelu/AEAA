using System;
using System.Collections.Generic;
using System.Text;

namespace AEAA.Models.Domains
{
    public class BaseObject
    {
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? LastModified { get; set; }
        public bool? IsActive { get; set; }
    }
}
