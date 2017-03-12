using CIS467_AMP.Models.StockRoom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CIS467_AMP.Models.Logbook
{
    public class LogbookStockroomRequest : LogbookBase
    {
        public Request Request { get; set; }
        public int RequestId { get; set; }
    }
}