using System;
using System.Collections.Generic;

namespace AdventureWorksPersistence.Models
{
    /// <summary>
    /// Product names and descriptions. Product descriptions are provided in multiple languages.
    /// </summary>
    public partial class vProductAndDescription
    {
        public int ProductID { get; set; }
        public string Name { get; set; } = null!;
        public string ProductModel { get; set; } = null!;
        public string CultureID { get; set; } = null!;
        public string Description { get; set; } = null!;
    }
}
