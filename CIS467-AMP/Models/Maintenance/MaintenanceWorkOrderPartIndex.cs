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
    /// MaintenanceWorkOrder - Link to work order
    /// MaintenanceWorkOrderId - Link to work order - for forms
    /// ManufacturerPart - Link to Manufacturer part number
    /// ManufacturerPartId - Link to Manufacturer part number - for forms
    /// Number - number of items used
    /// </summary>
    public class MaintenanceWorkOrderPartIndex
    {
        public int Id { get; set; }
        public MaintenanceWorkOrder MaintenanceWorkOrder { get; set; }
        public int MaintenanceWorkOrderId { get; set; }
        public ManufacturerPart ManufacturerPart { get; set; }
        public int ManufacturerPartId { get; set; }
        public int Number { get; set; }
    }
}
