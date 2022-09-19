using AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorksPersistence.Entities.Product
{
    public class EditProductDto
    {
        [Key]
        /// <summary>
        /// Primary key for Product records.
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Name of the product.
        /// </summary>
        public string ProductName { get; set; } = null!;
        /// <summary>
        /// Unique product identification number.
        /// </summary>
        public string ProductNumber { get; set; } = null!;
        /// <summary>
        /// 0 = Product is purchased, 1 = Product is manufactured in-house.
        /// </summary>
        public bool? MakeFlag { get; set; }
        /// <summary>
        /// 0 = Product is not a salable item. 1 = Product is salable.
        /// </summary>
        public bool? FinishedGoodsFlag { get; set; }
        /// <summary>
        /// Product color.
        /// </summary>
        public string? Color { get; set; }
        /// <summary>
        /// Minimum inventory quantity. 
        /// </summary>
        public short SafetyStockLevel { get; set; }
        /// <summary>
        /// Inventory level that triggers a purchase order or work order. 
        /// </summary>
        public short ReorderPoint { get; set; }
        /// <summary>
        /// Standard cost of the product.
        /// </summary>
        public decimal StandardCost { get; set; }
        /// <summary>
        /// Selling price.
        /// </summary>
        public decimal ListPrice { get; set; }
        /// <summary>
        /// Product size.
        /// </summary>
        public string? Size { get; set; }
        /// <summary>
        /// Unit of measure for Size column.
        /// </summary>
        public string? SizeUnitMeasureCode { get; set; }
        /// <summary>
        /// Unit of measure for Weight column.
        /// </summary>
        public string? WeightUnitMeasureCode { get; set; }
        /// <summary>
        /// Product weight.
        /// </summary>
        public decimal? Weight { get; set; }
        /// <summary>
        /// Number of days required to manufacture the product.
        /// </summary>
        public int DaysToManufacture { get; set; }
        /// <summary>
        /// R = Road, M = Mountain, T = Touring, S = Standard
        /// </summary>
        public string? ProductLine { get; set; }
        /// <summary>
        /// H = High, M = Medium, L = Low
        /// </summary>
        public string? Class { get; set; }
        /// <summary>
        /// W = Womens, M = Mens, U = Universal
        /// </summary>
        public string? Style { get; set; }
        /// <summary>
        /// Product is a member of this product subcategory. Foreign key to ProductSubCategory.ProductSubCategoryID. 
        /// </summary>
        public int? ProductSubcategoryID { get; set; }
        /// <summary>
        /// Product is a member of this product model. Foreign key to ProductModel.ProductModelID.
        /// </summary>
        public int? ProductModelID { get; set; }
        /// <summary>
        /// Date the product was available for sale.
        /// </summary>
        public DateTime SellStartDate { get; set; }
        /// <summary>
        /// Date the product was no longer available for sale.
        /// </summary>
        public DateTime? SellEndDate { get; set; }
        /// <summary>
        /// Date the product was discontinued.
        /// </summary>
        public DateTime? DiscontinuedDate { get; set; }
        /// <summary>
        /// ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        /// </summary>
        public Guid rowguid { get; set; }
        /// <summary>
        /// Date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }
    }

    public class EditProductDtoMapper : Profile
    {
        public EditProductDtoMapper()
        {
            CreateMap<EditProductDto, Models.Product>()
                .ForMember(s => s.ProductID, d => d.MapFrom(x => x.ID))
                .ForMember(s => s.Name, d => d.MapFrom(x => x.ProductName))
                .ReverseMap();
        }
    }
}
