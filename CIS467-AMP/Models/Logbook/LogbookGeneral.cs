using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CIS467_AMP.Models.Logbook
{
    public class LogbookGeneral : LogbookBase
    {
        public string Entry { get; set; }
        public LogbookGeneralStatus LogbookGeneralStatus { get; set; }
        public int LogbookGeneralStatusId { get; set; }
    }
}