using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace CIS467_AMP.Models.Logbook
{
    /// <summary>
    /// This class is just a type class for the type of logbook entry
    /// Id - Record ID
    /// Name - Name of logbook entry type
    /// </summary>
    public class LogbookType
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}