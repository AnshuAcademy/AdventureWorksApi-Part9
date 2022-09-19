using System;
using System.Collections.Generic;

namespace AdventureWorksPersistence.Models
{
    /// <summary>
    /// Cross-reference table mapping stores, vendors, and employees to people
    /// </summary>
    public partial class BusinessEntityContact
    {
        /// <summary>
        /// Primary key. Foreign key to BusinessEntity.BusinessEntityID.
        /// </summary>
        public int BusinessEntityID { get; set; }
        /// <summary>
        /// Primary key. Foreign key to Person.BusinessEntityID.
        /// </summary>
        public int PersonID { get; set; }
        /// <summary>
        /// Primary key.  Foreign key to ContactType.ContactTypeID.
        /// </summary>
        public int ContactTypeID { get; set; }
        /// <summary>
        /// ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        /// </summary>
        public Guid rowguid { get; set; }
        /// <summary>
        /// Date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        public virtual BusinessEntity BusinessEntity { get; set; } = null!;
        public virtual ContactType ContactType { get; set; } = null!;
        public virtual Person Person { get; set; } = null!;
    }
}
