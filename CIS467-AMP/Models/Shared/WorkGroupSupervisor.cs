namespace CIS467_AMP.Models.Shared
{
    /// <summary>
    /// Work group supervisor listings - can have more than one supervisor in a work group
    /// 
    /// WorkGroupSupervisorsID - ID of entry
    /// WorkerID - Id of supervisor
    /// WorkGroupID - Id of group supervising
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