using Business.Abstract;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading;

namespace WebApı.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {

        ICategorySerivce _categorySerivce;

        public CategoriesController(ICategorySerivce categorySerivce)
        {
            this._categorySerivce = categorySerivce;
        }


        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {

            var result = _categorySerivce.GetAll();
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }
        [HttpPost("Add")]
        public IActionResult Add(Category category)
        {
            var result = _categorySerivce.Add(category);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }
        [HttpPost("Delet")]
        public IActionResult Delelt(Category category)
        {
            var result = _categorySerivce.Delete(category);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("Update")]
        public IActionResult Update(Category category)
        {
            var result = _categorySerivce.Update(category);
            if (result.Success)
            {

                return Ok(result);

            }
            return BadRequest(result);

        }

        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var result = _categorySerivce.Get(id);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }
    }


}

