using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CIS467_AMP.Models.Shared
{
    /// <summary>D:\Rodney\OneDrive\git\cis467-amp-cmms\CIS467-AMP\Models\Shared\PartsListIndex.cs
    /// This is an index of parts types. Mostly used when setting up job plans
    /// Id - Id for this record 
    /// Name - name of part
    /// </summary>
    public class ManufacturerPartType
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}