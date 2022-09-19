using AdventureWorksPersistence.DataAccess;
using AdventureWorksPersistence.Entities.Product;
using AdventureWorksPersistence.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using System.Linq.Expressions;

namespace AdventureWorksApi.Controllers.v3
{
    [Route("api/[area]/[controller]")]
    [ApiController]
    [Area("Orders")]
    [ApiVersion("3.0")]
    public class ProductsController : ControllerBase
    {
        private readonly IAdventureWorksDataAccess data;

        public ProductsController(IAdventureWorksDataAccess data)
        {
            this.data = data;
        }

        [HttpGet("GetProducts")]
        public async Task<IActionResult> GetProducts()
        {
            return Ok(await data.GetProducts());

        }

        [EnableQuery]
        [HttpGet("GetProductsDynamic")]
        public async Task<IActionResult> GetProductsDynamic(ODataQueryOptions<ProductDto> options)
        {
            return Ok(await data.GetProductDynamic(options));
        }

        [HttpGet("GetProductsByName")]
        public async Task<IActionResult> GetProductByName(string productName)
        {
            var predicates = new List<Expression<Func<Product, bool>>>();
            Expression<Func<Product, bool>> expression = x => x.Name.Contains(productName);
            predicates.Add(expression);

            return Ok(await data.GetProducts<ProductDto>(predicates));

        }

        [HttpGet("GetProductsByProductNumber")]
        public async Task<IActionResult> GetProductsByProductNumber(string productNumber)
        {
            var predicates = new List<Expression<Func<Product, bool>>>();
            Expression<Func<Product, bool>> expression = x => x.ProductNumber.Contains(productNumber);
            predicates.Add(expression);

            return Ok(await data.GetProducts<ProductDto>(predicates));
        }
        [HttpGet("GetProductsByProductAndProductNumber")]
        public async Task<IActionResult> GetProductsByProductAndProductNumber(string productName,string productNumber)
        {
            var predicates = new List<Expression<Func<Product, bool>>>();
            Expression<Func<Product, bool>> expression1 = x => x.ProductNumber.Contains(productNumber);
            Expression<Func<Product, bool>> expression2 = x => x.Name.Contains(productName);
            predicates.Add(expression1);
            predicates.Add(expression2);

            return Ok(await data.GetProducts<ProductDto>(predicates));
        }


        [HttpGet("GetProductByID")]
        public async Task<IActionResult> GetProductByID(int id)
        {
            return Ok(await data.GetProductById(id));

        }

        [HttpGet("GetCustomProductByID")]
        public async Task<IActionResult> GetCustomProductByID(int id)
        {
            return Ok(await data.GetCustomProductById(id));

        }

        [HttpPost("AddProduct")]
        public async Task<int> AddProduct(AddProductDto addProductDto)
        {
            return await data.AddProduct(addProductDto);
        }

        [HttpPut("EditProduct")]
        public async Task<bool> EditProduct(EditProductDto editProductDto,int id)
        {
            return await data.EditProduct(editProductDto, id);
        }

    }
}
