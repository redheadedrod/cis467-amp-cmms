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
<<<<<<< HEAD
    /// ManufacturerPart - Link to Manufacturer part number of variant
    /// ManufacturerPartId - Link to Manufacturer part number of variant - for forms
=======
    /// ManufacturerToVariantPartIndex - Link to Manufacturer part number of variant
    /// ManufacturerToVariantPartIndexId - Link to Manufacturer part number of variant - for forms
>>>>>>> 4d04ce757e5de3c3f7ba312936954e2f28b6e28a
    /// Number - number of items used
    /// </summary>
    public class MaintenanceWorkOrderPartIndex
    {
        public int Id { get; set; }
        public MaintenanceWorkOrder MaintenanceWorkOrder { get; set; }
        public int MaintenanceWorkOrderId { get; set; }
<<<<<<< HEAD
        public ManufacturerPart ManufacturerPart { get; set; }
        public int ManufacturerPartId { get; set; }
=======
        public ManufacturerToVariantPartIndex PManufacturerToVariantPartIndex { get; set; }
        public int ManufacturerToVariantPartIndexId { get; set; }
>>>>>>> 4d04ce757e5de3c3f7ba312936954e2f28b6e28a
        public int Number { get; set; }
    }
}
