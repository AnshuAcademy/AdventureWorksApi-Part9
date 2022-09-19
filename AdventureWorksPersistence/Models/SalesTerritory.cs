using System;
using System.Collections.Generic;

namespace AdventureWorksPersistence.Models
{
    /// <summary>
    /// Sales territory lookup table.
    /// </summary>
    public partial class SalesTerritory
    {
        public SalesTerritory()
        {
            Customer = new HashSet<Customer>();
            SalesOrderHeader = new HashSet<SalesOrderHeader>();
            SalesPerson = new HashSet<SalesPerson>();
            SalesTerritoryHistory = new HashSet<SalesTerritoryHistory>();
            StateProvince = new HashSet<StateProvince>();
        }

        /// <summary>
        /// Primary key for SalesTerritory records.
        /// </summary>
        public int TerritoryID { get; set; }
        /// <summary>
        /// Sales territory description
        /// </summary>
        public string Name { get; set; } = null!;
        /// <summary>
        /// ISO standard country or region code. Foreign key to CountryRegion.CountryRegionCode. 
        /// </summary>
        public string CountryRegionCode { get; set; } = null!;
        /// <summary>
        /// Geographic area to which the sales territory belong.
        /// </summary>
        public string Group { get; set; } = null!;
        /// <summary>
        /// Sales in the territory year to date.
        /// </summary>
        public decimal SalesYTD { get; set; }
        /// <summary>
        /// Sales in the territory the previous year.
        /// </summary>
        public decimal SalesLastYear { get; set; }
        /// <summary>
        /// Business costs in the territory year to date.
        /// </summary>
        public decimal CostYTD { get; set; }
        /// <summary>
        /// Business costs in the territory the previous year.
        /// </summary>
        public decimal CostLastYear { get; set; }
        /// <summary>
        /// ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        /// </summary>
        public Guid rowguid { get; set; }
        /// <summary>
        /// Date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        public virtual CountryRegion CountryRegionCodeNavigation { get; set; } = null!;
        public virtual ICollection<Customer> Customer { get; set; }
        public virtual ICollection<SalesOrderHeader> SalesOrderHeader { get; set; }
        public virtual ICollection<SalesPerson> SalesPerson { get; set; }
        public virtual ICollection<SalesTerritoryHistory> SalesTerritoryHistory { get; set; }
        public virtual ICollection<StateProvince> StateProvince { get; set; }
    }
}
