using System;
using System.Collections.Generic;

namespace AdventureWorksPersistence.Models
{
    /// <summary>
    /// Lookup table of customer purchase reasons.
    /// </summary>
    public partial class SalesReason
    {
        public SalesReason()
        {
            SalesOrderHeaderSalesReason = new HashSet<SalesOrderHeaderSalesReason>();
        }

        /// <summary>
        /// Primary key for SalesReason records.
        /// </summary>
        public int SalesReasonID { get; set; }
        /// <summary>
        /// Sales reason description.
        /// </summary>
        public string Name { get; set; } = null!;
        /// <summary>
        /// Category the sales reason belongs to.
        /// </summary>
        public string ReasonType { get; set; } = null!;
        /// <summary>
        /// Date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReason { get; set; }
    }
}
