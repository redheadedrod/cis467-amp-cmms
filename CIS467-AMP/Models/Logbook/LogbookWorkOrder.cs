using CIS467_AMP.Models.Maintenance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CIS467_AMP.Models.Logbook
{
    public class LogbookWorkOrder : LogbookBase
    {
        public WorkOrder WorkOrder { get; set; }
        public int WorkOrderId { get; set; }
    }
}