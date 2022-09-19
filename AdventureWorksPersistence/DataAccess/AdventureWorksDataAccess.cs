using AdventureWorksPersistence.Entities.Product;
using AdventureWorksPersistence.Models;
using AutoMapper;
using AutoMapper.AspNet.OData;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AdventureWorksPersistence.DataAccess
{
    public class AdventureWorksDataAccess : IAdventureWorksDataAccess
    {
        private readonly AdventureWorksDBContext context;
        private readonly IMapper mapper;

        public AdventureWorksDataAccess(AdventureWorksDBContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<int> AddProduct(AddProductDto addProductDto)
        {
            var product = mapper.Map<Product>(addProductDto);

            context.Add(product);

            await context.SaveChangesAsync();

            return product.ProductID;
        }

        public async Task<bool> EditProduct(EditProductDto editProductDto, int id)
        {
            var existingProduct = await context.Product.FindAsync(id);
           
            if (existingProduct != null)
            {
                mapper.Map(editProductDto, existingProduct);
                await context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<ProductDto?> GetCustomProductById(int id)
        {
            var productDto = await context.Product
                .Where(x => x.ProductID == id)
                .ProjectTo<ProductDto>(mapper.ConfigurationProvider)
                .FirstOrDefaultAsync();
            return productDto;
        }

        public async Task<Product?> GetProductById(int id)
        {
            return await context.Product.FindAsync(id);
        } 

        public async Task<List<ProductDto>> GetProducts()
        {
            var productdtos = await context.Product
                .ProjectTo<ProductDto>(mapper.ConfigurationProvider)
                .Take(20).ToListAsync();

            return productdtos;
        }

        public async Task<IQueryable<ProductDto>> GetProductDynamic(ODataQueryOptions<ProductDto> options)
        {
            var query = await context.Product.GetQueryAsync(mapper, options, null);
            return query;
        }

        public async Task<List<T>> GetProducts<T>(List<Expression<Func<Product, bool>>> predicates)
        {
            var query = GetProductsQuery(predicates);

            var data = await query
                              .ProjectTo<T>(mapper.ConfigurationProvider)
                              .ToListAsync();

            return data;
        }

        private IQueryable<Product> GetProductsQuery(List<Expression<Func<Product, bool>>> predicates)
        {
            var query = context.Product
                        .AsNoTracking()
                        .AsQueryable();

            foreach(var predicate in predicates)
            {
                query = query.Where(predicate);
            }

            return query;
        }
    }
}