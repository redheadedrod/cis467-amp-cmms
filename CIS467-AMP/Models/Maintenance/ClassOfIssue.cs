using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CIS467_AMP.Models.Maintenance
{
    /// <summary>
    /// This is the Class of issue being  repaired (examples - Pipe, Pump, Valve)
    /// Id - record ID
    /// Name - Name of Issue Class
    /// </summary>
    public class ClassOfIssue
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}