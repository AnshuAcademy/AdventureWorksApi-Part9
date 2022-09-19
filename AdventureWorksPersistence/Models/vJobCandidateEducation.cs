using System;
using System.Collections.Generic;

namespace AdventureWorksPersistence.Models
{
    /// <summary>
    /// Displays the content from each education related element in the xml column Resume in the HumanResources.JobCandidate table. The content has been localized into French, Simplified Chinese and Thai. Some data may not display correctly unless supplemental language support is installed.
    /// </summary>
    public partial class vJobCandidateEducation
    {
        public int JobCandidateID { get; set; }
        public string? Edu_Level { get; set; }
        public DateTime? Edu_StartDate { get; set; }
        public DateTime? Edu_EndDate { get; set; }
        public string? Edu_Degree { get; set; }
        public string? Edu_Major { get; set; }
        public string? Edu_Minor { get; set; }
        public string? Edu_GPA { get; set; }
        public string? Edu_GPAScale { get; set; }
        public string? Edu_School { get; set; }
        public string? Edu_Loc_CountryRegion { get; set; }
        public string? Edu_Loc_State { get; set; }
        public string? Edu_Loc_City { get; set; }
    }
}
