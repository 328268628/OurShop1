using AutoMapper;
using DTO;
using Entitis;
using Microsoft.AspNetCore.Mvc;
using Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OurShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IProductService productService;
        IMapper mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            this.productService = productService;
            this.mapper = mapper;
        }

        // GET: api/<ProductController>
        [HttpGet]
        public async Task<List<ProductDTO>> Get([FromQuery] string? desc, [FromQuery] int? minPrice, [FromQuery] int? maxPrice, [FromQuery] int?[] categoryIds)
        {
            List<Product> products= await productService.GetProducts( desc,  minPrice,  maxPrice,  categoryIds);
            List<ProductDTO> productDTOs = mapper.Map<List<Product>, List<ProductDTO>>(products);
            return productDTOs;
        }

        // GET api/<ProductController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        

        //    return "value";
        //}

        // POST api/<ProductController>
        //[HttpPost]
        //public void Post([FromBody] Product product)
        //{
        //    //return await productService.AddProduct(product);
        //}

        // PUT api/<ProductController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] Product productToUpdate)
        //{
        //     /*await productService.UpdateProduct(id, productToUpdate);*/
        //} 

        // DELETE api/<ProductController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id, [FromBody] Product product)
        //{
        //    //await productService.DeleteProducts(id, product);
        //}
    }
}
