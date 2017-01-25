using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CIS467_AMP.Areas.Shared.Model
{
    /// <summary>
    /// Listing of parts for specific job plan
    /// 
    /// JobPlanIndexID - ID for entry
    /// JobPlanID - id of job plan
    /// PartID - part ID for part required
    /// </summary>
    public class JobPlanParts
    {
        public int JobPlanIndexID { get; set; }
        public int JobPlanID { get; set; }
        public int PartID { get; set; }

    }
}