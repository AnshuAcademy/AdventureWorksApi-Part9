using System;
using System.Collections.Generic;

namespace AdventureWorksPersistence.Models
{
    /// <summary>
    /// Items required to make bicycles and bicycle subassemblies. It identifies the heirarchical relationship between a parent product and its components.
    /// </summary>
    public partial class BillOfMaterials
    {
        /// <summary>
        /// Primary key for BillOfMaterials records.
        /// </summary>
        public int BillOfMaterialsID { get; set; }
        /// <summary>
        /// Parent product identification number. Foreign key to Product.ProductID.
        /// </summary>
        public int? ProductAssemblyID { get; set; }
        /// <summary>
        /// Component identification number. Foreign key to Product.ProductID.
        /// </summary>
        public int ComponentID { get; set; }
        /// <summary>
        /// Date the component started being used in the assembly item.
        /// </summary>
        public DateTime StartDate { get; set; }
        /// <summary>
        /// Date the component stopped being used in the assembly item.
        /// </summary>
        public DateTime? EndDate { get; set; }
        /// <summary>
        /// Standard code identifying the unit of measure for the quantity.
        /// </summary>
        public string UnitMeasureCode { get; set; } = null!;
        /// <summary>
        /// Indicates the depth the component is from its parent (AssemblyID).
        /// </summary>
        public short BOMLevel { get; set; }
        /// <summary>
        /// Quantity of the component needed to create the assembly.
        /// </summary>
        public decimal PerAssemblyQty { get; set; }
        /// <summary>
        /// Date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        public virtual Product Component { get; set; } = null!;
        public virtual Product? ProductAssembly { get; set; }
        public virtual UnitMeasure UnitMeasureCodeNavigation { get; set; } = null!;
    }
}
