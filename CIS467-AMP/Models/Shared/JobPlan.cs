namespace CIS467_AMP.Models.Shared
{
    /// <summary>
    /// Job plan listings
    /// 
    /// JobPlanID - ID of this jobplan
    /// JobPlanName - Name of plan "example - Inbound Seal replacement"
    /// VariantID - ID of asset type variant that plan is related to
    ///  </summary>
    public class JobPlan
    {
        public int JobPlanId { get; set; }
        public string JobPlanName { get; set; }
        public Variant VariantId { get; set; }
    }
}