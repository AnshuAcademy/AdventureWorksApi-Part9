using System;
using System.Collections.Generic;

namespace AdventureWorksPersistence.Models
{
    /// <summary>
    /// Displays the content from each element in the xml column Instructions for each product in the Production.ProductModel table that has manufacturing instructions.
    /// </summary>
    public partial class vProductModelInstructions
    {
        public int ProductModelID { get; set; }
        public string Name { get; set; } = null!;
        public string? Instructions { get; set; }
        public int? LocationID { get; set; }
        public decimal? SetupHours { get; set; }
        public decimal? MachineHours { get; set; }
        public decimal? LaborHours { get; set; }
        public int? LotSize { get; set; }
        public string? Step { get; set; }
        public Guid rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
