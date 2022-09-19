using System;
using System.Collections.Generic;

namespace AdventureWorksPersistence.Models
{
    /// <summary>
    /// Sales representative current information.
    /// </summary>
    public partial class SalesPerson
    {
        public SalesPerson()
        {
            SalesOrderHeader = new HashSet<SalesOrderHeader>();
            SalesPersonQuotaHistory = new HashSet<SalesPersonQuotaHistory>();
            SalesTerritoryHistory = new HashSet<SalesTerritoryHistory>();
            Store = new HashSet<Store>();
        }

        /// <summary>
        /// Primary key for SalesPerson records. Foreign key to Employee.BusinessEntityID
        /// </summary>
        public int BusinessEntityID { get; set; }
        /// <summary>
        /// Territory currently assigned to. Foreign key to SalesTerritory.SalesTerritoryID.
        /// </summary>
        public int? TerritoryID { get; set; }
        /// <summary>
        /// Projected yearly sales.
        /// </summary>
        public decimal? SalesQuota { get; set; }
        /// <summary>
        /// Bonus due if quota is met.
        /// </summary>
        public decimal Bonus { get; set; }
        /// <summary>
        /// Commision percent received per sale.
        /// </summary>
        public decimal CommissionPct { get; set; }
        /// <summary>
        /// Sales total year to date.
        /// </summary>
        public decimal SalesYTD { get; set; }
        /// <summary>
        /// Sales total of previous year.
        /// </summary>
        public decimal SalesLastYear { get; set; }
        /// <summary>
        /// ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        /// </summary>
        public Guid rowguid { get; set; }
        /// <summary>
        /// Date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        public virtual Employee BusinessEntity { get; set; } = null!;
        public virtual SalesTerritory? Territory { get; set; }
        public virtual ICollection<SalesOrderHeader> SalesOrderHeader { get; set; }
        public virtual ICollection<SalesPersonQuotaHistory> SalesPersonQuotaHistory { get; set; }
        public virtual ICollection<SalesTerritoryHistory> SalesTerritoryHistory { get; set; }
        public virtual ICollection<Store> Store { get; set; }
    }
}
