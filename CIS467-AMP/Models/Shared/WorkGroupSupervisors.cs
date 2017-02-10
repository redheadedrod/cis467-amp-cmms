namespace CIS467_AMP.Models.Shared
{
    /// <summary>
    /// Work group supervisor listings - can have more than one supervisor in a work group
    /// 
    /// WorkGroupSupervisorsID - ID of entry
    /// WorkerID - Id of supervisor
    /// WorkGroupID - Id of group supervising
    /// </summary>
    public class WorkGroupSupervisors
    {
        public int WorkGroupSupervisorsId { get; set; }
        public Worker WorkerId { get; set; }
        public WorkGroup WorkGroupId { get; set; }
    }
}