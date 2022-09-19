using System;
using System.Collections.Generic;

namespace AdventureWorksPersistence.Models
{
    /// <summary>
    /// Current customer information. Also see the Person and Store tables.
    /// </summary>
    public partial class Customer
    {
        public Customer()
        {
            SalesOrderHeader = new HashSet<SalesOrderHeader>();
        }

        /// <summary>
        /// Primary key.
        /// </summary>
        public int CustomerID { get; set; }
        /// <summary>
        /// Foreign key to Person.BusinessEntityID
        /// </summary>
        public int? PersonID { get; set; }
        /// <summary>
        /// Foreign key to Store.BusinessEntityID
        /// </summary>
        public int? StoreID { get; set; }
        /// <summary>
        /// ID of the territory in which the customer is located. Foreign key to SalesTerritory.SalesTerritoryID.
        /// </summary>
        public int? TerritoryID { get; set; }
        /// <summary>
        /// Unique number identifying the customer assigned by the accounting system.
        /// </summary>
        public string AccountNumber { get; set; } = null!;
        /// <summary>
        /// ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        /// </summary>
        public Guid rowguid { get; set; }
        /// <summary>
        /// Date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        public virtual Person? Person { get; set; }
        public virtual Store? Store { get; set; }
        public virtual SalesTerritory? Territory { get; set; }
        public virtual ICollection<SalesOrderHeader> SalesOrderHeader { get; set; }
    }
}
