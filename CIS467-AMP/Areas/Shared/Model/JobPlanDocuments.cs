﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CIS467_AMP.Areas.Shared.Model
{
    /// <summary>
    /// Job plan related documents - most of time should be one document but could be multiples
    /// 
    /// JobPlanDocsID - ID of entry
    /// JobPlanID - ID of jobplan related to
    /// Filename - Name of file for job plan
    /// </summary>
    public class JobPlanDocuments
    {
        public int JobPlanDocsId { get; set; }
        public JobPlan JobPlanId { get; set; }
        public string Filename { get; set; } 
    }
}