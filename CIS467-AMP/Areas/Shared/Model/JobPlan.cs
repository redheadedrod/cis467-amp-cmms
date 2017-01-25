using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CIS467_AMP.Areas.Shared.Model
{
    /// <summary>
    /// Job plan listings
    /// 
    /// JobPlanID - ID of this jobplan
    /// JobPlanName - Name of plan "example - Inbound Seal replacement"
    /// VariantID - ID of asset type variant that plan is related to
    ///  </summary>
    public class JobPlan
    {
        public int JobPlanID { get; set; }
        public string JobPlanName { get; set; }
        public string VariantID { get; set; }
    }
}