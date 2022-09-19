using System;
using System.Collections.Generic;

namespace AdventureWorksPersistence.Models
{
    /// <summary>
    /// Displays the content from each element in the xml column CatalogDescription for each product in the Production.ProductModel table that has catalog data.
    /// </summary>
    public partial class vProductModelCatalogDescription
    {
        public int ProductModelID { get; set; }
        public string Name { get; set; } = null!;
        public string? Summary { get; set; }
        public string? Manufacturer { get; set; }
        public string? Copyright { get; set; }
        public string? ProductURL { get; set; }
        public string? WarrantyPeriod { get; set; }
        public string? WarrantyDescription { get; set; }
        public string? NoOfYears { get; set; }
        public string? MaintenanceDescription { get; set; }
        public string? Wheel { get; set; }
        public string? Saddle { get; set; }
        public string? Pedal { get; set; }
        public string? BikeFrame { get; set; }
        public string? Crankset { get; set; }
        public string? PictureAngle { get; set; }
        public string? PictureSize { get; set; }
        public string? ProductPhotoID { get; set; }
        public string? Material { get; set; }
        public string? Color { get; set; }
        public string? ProductLine { get; set; }
        public string? Style { get; set; }
        public string? RiderExperience { get; set; }
        public Guid rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
