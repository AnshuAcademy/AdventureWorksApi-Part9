using System;
using System.Collections.Generic;

namespace AdventureWorksPersistence.Models
{
    /// <summary>
    /// Customers (resellers) of Adventure Works products.
    /// </summary>
    public partial class Store
    {
        public Store()
        {
            Customer = new HashSet<Customer>();
        }

        /// <summary>
        /// Primary key. Foreign key to Customer.BusinessEntityID.
        /// </summary>
        public int BusinessEntityID { get; set; }
        /// <summary>
        /// Name of the store.
        /// </summary>
        public string Name { get; set; } = null!;
        /// <summary>
        /// ID of the sales person assigned to the customer. Foreign key to SalesPerson.BusinessEntityID.
        /// </summary>
        public int? SalesPersonID { get; set; }
        /// <summary>
        /// Demographic informationg about the store such as the number of employees, annual sales and store type.
        /// </summary>
        public string? Demographics { get; set; }
        /// <summary>
        /// ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        /// </summary>
        public Guid rowguid { get; set; }
        /// <summary>
        /// Date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        public virtual BusinessEntity BusinessEntity { get; set; } = null!;
        public virtual SalesPerson? SalesPerson { get; set; }
        public virtual ICollection<Customer> Customer { get; set; }
    }
}
