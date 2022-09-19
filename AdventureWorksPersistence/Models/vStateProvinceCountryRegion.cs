using System;
using System.Collections.Generic;

namespace AdventureWorksPersistence.Models
{
    /// <summary>
    /// Joins StateProvince table with CountryRegion table.
    /// </summary>
    public partial class vStateProvinceCountryRegion
    {
        public int StateProvinceID { get; set; }
        public string StateProvinceCode { get; set; } = null!;
        public bool IsOnlyStateProvinceFlag { get; set; }
        public string StateProvinceName { get; set; } = null!;
        public int TerritoryID { get; set; }
        public string CountryRegionCode { get; set; } = null!;
        public string CountryRegionName { get; set; } = null!;
    }
}
