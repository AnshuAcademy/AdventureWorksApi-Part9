using System;
using System.Collections.Generic;

namespace AdventureWorksPersistence.Models
{
    /// <summary>
    /// Sale discounts lookup table.
    /// </summary>
    public partial class SpecialOffer
    {
        public SpecialOffer()
        {
            SpecialOfferProduct = new HashSet<SpecialOfferProduct>();
        }

        /// <summary>
        /// Primary key for SpecialOffer records.
        /// </summary>
        public int SpecialOfferID { get; set; }
        /// <summary>
        /// Discount description.
        /// </summary>
        public string Description { get; set; } = null!;
        /// <summary>
        /// Discount precentage.
        /// </summary>
        public decimal DiscountPct { get; set; }
        /// <summary>
        /// Discount type category.
        /// </summary>
        public string Type { get; set; } = null!;
        /// <summary>
        /// Group the discount applies to such as Reseller or Customer.
        /// </summary>
        public string Category { get; set; } = null!;
        /// <summary>
        /// Discount start date.
        /// </summary>
        public DateTime StartDate { get; set; }
        /// <summary>
        /// Discount end date.
        /// </summary>
        public DateTime EndDate { get; set; }
        /// <summary>
        /// Minimum discount percent allowed.
        /// </summary>
        public int MinQty { get; set; }
        /// <summary>
        /// Maximum discount percent allowed.
        /// </summary>
        public int? MaxQty { get; set; }
        /// <summary>
        /// ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        /// </summary>
        public Guid rowguid { get; set; }
        /// <summary>
        /// Date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<SpecialOfferProduct> SpecialOfferProduct { get; set; }
    }
}
