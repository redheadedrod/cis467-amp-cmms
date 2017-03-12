using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CIS467_AMP.Models.StockRoom
{
    /// <summary>
    /// Status of order request
    /// Id - Record Id
    /// Name - Text for name of status
    /// </summary>
    public class StockroomRequestStatus
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}