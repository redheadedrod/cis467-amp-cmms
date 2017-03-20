using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CIS467_AMP.Models.Logbook
{
    /// <summary>
    /// Status for General Logbook
    /// Id - Id of record
    /// Name - Text of status
    /// </summary>
    public class LogbookGeneralStatus
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}