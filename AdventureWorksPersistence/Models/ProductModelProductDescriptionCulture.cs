using System;
using System.Collections.Generic;

namespace AdventureWorksPersistence.Models
{
    /// <summary>
    /// Cross-reference table mapping product descriptions and the language the description is written in.
    /// </summary>
    public partial class ProductModelProductDescriptionCulture
    {
        /// <summary>
        /// Primary key. Foreign key to ProductModel.ProductModelID.
        /// </summary>
        public int ProductModelID { get; set; }
        /// <summary>
        /// Primary key. Foreign key to ProductDescription.ProductDescriptionID.
        /// </summary>
        public int ProductDescriptionID { get; set; }
        /// <summary>
        /// Culture identification number. Foreign key to Culture.CultureID.
        /// </summary>
        public string CultureID { get; set; } = null!;
        /// <summary>
        /// Date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        public virtual Culture Culture { get; set; } = null!;
        public virtual ProductDescription ProductDescription { get; set; } = null!;
        public virtual ProductModel ProductModel { get; set; } = null!;
    }
}
