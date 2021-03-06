﻿using AEAA.Payment.Core.Remitta.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace AEAA.Payment.Core.Remitta.Models.RRR
{
    public class RRRSplitPaymenWithCustomFieldAndLineitem : Payment
    {
        public LineItem lineItems { get; set; }
        public CustomField customFields { get; set; }
    }
}
