using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Antlr.Runtime;

namespace CIS467_AMP.Areas.Shared.Model
{
    /// <summary>
    /// parts listing
    /// 
    /// PartID - Id of entry    
    /// PartType - type of part - allows for easy selection of parts for different variants - useful for setting up job plans mostly
    /// Number - manufacturer parts number and can be alpha numeric
    /// Name - name of part
    /// ManID - manufacturer ID
    /// </summary>
    public class PartsList
    {
        public int PartID { get; set; }
        public int PartType { get; set; }
        public string Number { get; set;  } 
        public string Name { get; set; } 
        public int ManID { get; set; } 
    }
}