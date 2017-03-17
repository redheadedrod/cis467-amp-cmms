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
    /// ManufacturerToVariantPartIndex - Link to Manufacturer part number of variant
    /// ManufacturerToVariantPartIndexId - Link to Manufacturer part number of variant - for forms
    /// Number - number of items used
    /// </summary>
    public class MaintenanceWorkOrderPartIndex
    {
        public int Id { get; set; }
        public MaintenanceWorkOrder MaintenanceWorkOrder { get; set; }
        public int MaintenanceWorkOrderId { get; set; }
        public ManufacturerToVariantPartIndex PManufacturerToVariantPartIndex { get; set; }
        public int ManufacturerToVariantPartIndexId { get; set; }
        public int Number { get; set; }
    }
}
