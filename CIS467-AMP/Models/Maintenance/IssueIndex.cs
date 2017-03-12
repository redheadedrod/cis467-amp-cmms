using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CIS467_AMP.Models.Maintenance
{
    /**
     * This is an index of issues for each class of index
     * Id = id of this record
     * ClassId = class of the issue
     * IssueId = the actual issue (Done this way because multiple things can have same issue)
     */
    public class IssueIndex
    {
        public int Id { get; set; }
        public ClassOfIssue ClassOfissue { get; set; }
        public int ClassOfissueId { get; set; }
        public Issue Issue { get; set; }
        public int IssueId { get; set; }
    }
}