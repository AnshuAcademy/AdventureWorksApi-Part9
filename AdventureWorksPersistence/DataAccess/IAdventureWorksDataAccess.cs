using AdventureWorksPersistence.Entities.Product;
using AdventureWorksPersistence.Models;
using Microsoft.AspNetCore.OData.Query;
using System.Linq.Expressions;

namespace AdventureWorksPersistence.DataAccess
{
    public interface IAdventureWorksDataAccess
    {
        Task<List<ProductDto>> GetProducts();
        Task<IQueryable<ProductDto>> GetProductDynamic(ODataQueryOptions<ProductDto> options);
        Task<List<T>> GetProducts<T>(List<Expression<Func<Product, bool>>> predicates);
        Task<Product?> GetProductById(int id);
        Task<ProductDto?> GetCustomProductById(int id);
        Task<int> AddProduct(AddProductDto addProductDto);
        Task<bool> EditProduct(EditProductDto editProductDto,int id );
    }
}