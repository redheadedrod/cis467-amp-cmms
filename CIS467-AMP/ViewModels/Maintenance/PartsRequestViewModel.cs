using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using System.Web.Profile;
using CIS467_AMP.Models.Shared;
using CIS467_AMP.Models.StockRoom;

namespace CIS467_AMP.ViewModels.Maintenance
{
    public class PartsRequestViewModel
    {
        public List<StockRoomRequestLine> RequestLines { get; set; }
        public List<ManufacturerPart> ManufacturerParts { get; set; }
        public List<Manufacturer> Manufacturers { get; set; }
        public int WorkOrderNumber { get; set; }
        public int JobPlanNumber { get; set; }
        public string Lines { set; get; }
        public string Notes { get; set; }
    }
}