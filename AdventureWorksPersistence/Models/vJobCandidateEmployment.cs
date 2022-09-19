using System;
using System.Collections.Generic;

namespace AdventureWorksPersistence.Models
{
    /// <summary>
    /// Displays the content from each employement history related element in the xml column Resume in the HumanResources.JobCandidate table. The content has been localized into French, Simplified Chinese and Thai. Some data may not display correctly unless supplemental language support is installed.
    /// </summary>
    public partial class vJobCandidateEmployment
    {
        public int JobCandidateID { get; set; }
        public DateTime? Emp_StartDate { get; set; }
        public DateTime? Emp_EndDate { get; set; }
        public string? Emp_OrgName { get; set; }
        public string? Emp_JobTitle { get; set; }
        public string? Emp_Responsibility { get; set; }
        public string? Emp_FunctionCategory { get; set; }
        public string? Emp_IndustryCategory { get; set; }
        public string? Emp_Loc_CountryRegion { get; set; }
        public string? Emp_Loc_State { get; set; }
        public string? Emp_Loc_City { get; set; }
    }
}
