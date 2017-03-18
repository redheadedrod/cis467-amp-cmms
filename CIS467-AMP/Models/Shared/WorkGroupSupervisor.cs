namespace CIS467_AMP.Models.Shared
{
    /// <summary>
    /// Work group supervisor listings - can have more than one supervisor in a work group
    /// 
    /// Id - Record Id
    /// Worker - Link to worker
    /// WorkerId - Link to worker - used in forms
    /// WorkGroup - Group worker is supervisor of
    /// WorkGroupId - Group worker is supervisor of - used in forms
    /// </summary>
    public class WorkGroupSupervisor
    {
        public int Id { get; set; }
        public Worker Worker { get; set; }
        public int WorkerId { get; set; }
        public WorkGroup WorkGroup { get; set; }
        public int WorkGroupId { get; set; }
    }
}
