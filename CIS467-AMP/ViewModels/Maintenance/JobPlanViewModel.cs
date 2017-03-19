using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using CIS467_AMP.Models.Shared;

namespace CIS467_AMP.ViewModels.Maintenance
{
    public class JobPlanViewModel
    {
        public JobPlan JobPlan { get; set; }
        public JobPlanDocument JobPlanDocument { get; set; }
        public IEnumerable<ManufacturerPart> ManufacturerParts { get; set; }
    }
}