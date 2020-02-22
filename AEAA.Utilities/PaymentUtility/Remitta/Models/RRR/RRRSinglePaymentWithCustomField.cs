using System;
using System.Collections.Generic;
using System.Text;

namespace AEAA.Payment.Core.Remitta.Models.RRR
{
    public class RRRSinglePaymentWithCustomField : Payment
    {
        public CustomField customFields { get; set; }
    }
}
