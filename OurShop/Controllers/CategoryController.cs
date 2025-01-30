using Entitis;
using Microsoft.AspNetCore.Mvc;
using Services;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OurShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase

    {
        ICategoryService categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        // GET: api/<CategoryController>
        [HttpGet]
        public async Task<List<Category>> Get()
        {
            return await categoryService.GetCategory();
        }

        // GET api/<CategoryController>/5
        //[HttpGet("{id}")]
        //public void GetById(int id)
        //{
        //    //return await categoryService.GetCategoryById(id);
        //}

        // POST api/<CategoryController>
        //[HttpPost]
        //public void Post([FromBody] Category category)
        //{
        //    //return await categoryService.AddCategory(category);
        //}

        // PUT api/<CategoryController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] Category category)
        //{
        //     //await categoryService.UpdateCategory(id, category);
        //}

        // DELETE api/<CategoryController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id, [FromBody] Category category)
        //{
        //    //await categoryService.DeleteCategory(id, category);
        //}
    }
}
