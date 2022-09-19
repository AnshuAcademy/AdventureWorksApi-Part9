using AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorksPersistence.Entities.Product
{
    public class ProductDto
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
        ///   /// <summary>
        /// Product color.
        /// </summary>
        public string? Color { get; set; }
        /// <summary>
        /// Selling price.
        /// </summary>
        public decimal ListPrice { get; set; }

        public string? ProductSubCategoryName { get; set; }

        public string? ProductCategoryName { get; set; }
    }


    public class ProductDtoMapper : Profile
    {
        public ProductDtoMapper()
        {
            CreateMap<Models.Product, ProductDto>()
                .ForMember(s => s.ID, d => d.MapFrom(x => x.ProductID))
                .ForMember(s => s.ProductName, d => d.MapFrom(x => x.Name))
                .ForMember(s => s.ProductSubCategoryName, d => d.MapFrom(x => x.ProductSubcategory == null ? null : x.ProductSubcategory.Name))
                .ForMember(s => s.ProductCategoryName,
                d => d.MapFrom(x => x.ProductSubcategory == null ? null : x.ProductSubcategory.ProductCategory == null ? null : x.ProductSubcategory.ProductCategory.Name));
        }
    }
}
