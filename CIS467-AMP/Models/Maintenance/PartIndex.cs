using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CIS467_AMP.Models.Shared;

namespace CIS467_AMP.Models.Maintenance
{
    /// <summary>
    /// This is a list of parts for a work order
    /// Id - record id
    /// WorkOrderId - Id of the work order this is attached to
    /// PartsIndex - Part from the parts listing
    /// Number - number of items used
    /// </summary>
    public class PartIndex
    {
        public int Id { get; set; }
        public WorkOrderRecord WorkOrderId { get; set; }
        public PartsListIndex PartsIndex { get; set; }
        public int Number { get; set; }
    }
}