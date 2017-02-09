using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CIS467_AMP.Areas.Shared.Model
{
    /// <summary>
    /// Work Group listing
    /// 
    /// WorkGroupID - Id of entry
    /// Name - name of workgroup
    /// </summary>
    public class WorkGroup
    {
        public int WorkGroupId { get; set; }
        public string Name { get; set; }
    }
}