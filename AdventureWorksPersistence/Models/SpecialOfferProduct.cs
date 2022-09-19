using System;
using System.Collections.Generic;

namespace AdventureWorksPersistence.Models
{
    /// <summary>
    /// Cross-reference table mapping products to special offer discounts.
    /// </summary>
    public partial class SpecialOfferProduct
    {
        public SpecialOfferProduct()
        {
            SalesOrderDetail = new HashSet<SalesOrderDetail>();
        }

        /// <summary>
        /// Primary key for SpecialOfferProduct records.
        /// </summary>
        public int SpecialOfferID { get; set; }
        /// <summary>
        /// Product identification number. Foreign key to Product.ProductID.
        /// </summary>
        public int ProductID { get; set; }
        /// <summary>
        /// ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        /// </summary>
        public Guid rowguid { get; set; }
        /// <summary>
        /// Date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        public virtual Product Product { get; set; } = null!;
        public virtual SpecialOffer SpecialOffer { get; set; } = null!;
        public virtual ICollection<SalesOrderDetail> SalesOrderDetail { get; set; }
    }
}
