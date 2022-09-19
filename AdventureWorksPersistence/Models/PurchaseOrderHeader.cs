using System;
using System.Collections.Generic;

namespace AdventureWorksPersistence.Models
{
    /// <summary>
    /// General purchase order information. See PurchaseOrderDetail.
    /// </summary>
    public partial class PurchaseOrderHeader
    {
        public PurchaseOrderHeader()
        {
            PurchaseOrderDetail = new HashSet<PurchaseOrderDetail>();
        }

        /// <summary>
        /// Primary key.
        /// </summary>
        public int PurchaseOrderID { get; set; }
        /// <summary>
        /// Incremental number to track changes to the purchase order over time.
        /// </summary>
        public byte RevisionNumber { get; set; }
        /// <summary>
        /// Order current status. 1 = Pending; 2 = Approved; 3 = Rejected; 4 = Complete
        /// </summary>
        public byte Status { get; set; }
        /// <summary>
        /// Employee who created the purchase order. Foreign key to Employee.BusinessEntityID.
        /// </summary>
        public int EmployeeID { get; set; }
        /// <summary>
        /// Vendor with whom the purchase order is placed. Foreign key to Vendor.BusinessEntityID.
        /// </summary>
        public int VendorID { get; set; }
        /// <summary>
        /// Shipping method. Foreign key to ShipMethod.ShipMethodID.
        /// </summary>
        public int ShipMethodID { get; set; }
        /// <summary>
        /// Purchase order creation date.
        /// </summary>
        public DateTime OrderDate { get; set; }
        /// <summary>
        /// Estimated shipment date from the vendor.
        /// </summary>
        public DateTime? ShipDate { get; set; }
        /// <summary>
        /// Purchase order subtotal. Computed as SUM(PurchaseOrderDetail.LineTotal)for the appropriate PurchaseOrderID.
        /// </summary>
        public decimal SubTotal { get; set; }
        /// <summary>
        /// Tax amount.
        /// </summary>
        public decimal TaxAmt { get; set; }
        /// <summary>
        /// Shipping cost.
        /// </summary>
        public decimal Freight { get; set; }
        /// <summary>
        /// Total due to vendor. Computed as Subtotal + TaxAmt + Freight.
        /// </summary>
        public decimal TotalDue { get; set; }
        /// <summary>
        /// Date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        public virtual Employee Employee { get; set; } = null!;
        public virtual ShipMethod ShipMethod { get; set; } = null!;
        public virtual Vendor Vendor { get; set; } = null!;
        public virtual ICollection<PurchaseOrderDetail> PurchaseOrderDetail { get; set; }
    }
}
