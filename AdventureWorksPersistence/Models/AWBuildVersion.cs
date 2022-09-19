using System;
using System.Collections.Generic;

namespace AdventureWorksPersistence.Models
{
    /// <summary>
    /// Current version number of the AdventureWorks 2016 sample database. 
    /// </summary>
    public partial class AWBuildVersion
    {
        /// <summary>
        /// Primary key for AWBuildVersion records.
        /// </summary>
        public byte SystemInformationID { get; set; }
        /// <summary>
        /// Version number of the database in 9.yy.mm.dd.00 format.
        /// </summary>
        public string Database_Version { get; set; } = null!;
        /// <summary>
        /// Date and time the record was last updated.
        /// </summary>
        public DateTime VersionDate { get; set; }
        /// <summary>
        /// Date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }
    }
}
