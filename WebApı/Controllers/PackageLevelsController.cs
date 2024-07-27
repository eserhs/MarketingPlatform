using Business.Abstract;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApı.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PackageLevelsController : ControllerBase
    {

        IPackageLevelService _packageLevelService;

        public PackageLevelsController(IPackageLevelService packageLevelService)
        {
            _packageLevelService = packageLevelService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _packageLevelService.GetAll();
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _packageLevelService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }

        [HttpGet("getbyName")]
        public IActionResult GetByName(string name) {
        var result = (_packageLevelService.GetByName(name));
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(PackageLevel packageLevel)
        {
            var result = _packageLevelService.Add(packageLevel);   
            if (result.Success)
            {
                return Ok(result);  
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(PackageLevel packageLevel) {
           var result = _packageLevelService.Remove(packageLevel);
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        
        }
        [HttpPost("uptade")]
        public IActionResult Update(PackageLevel packageLevel)
        {
            var result = _packageLevelService.Update(packageLevel);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbypackagedto")]
        public IActionResult GetByPackageDto()
        {
            var result = _packageLevelService.GetByPackageDto();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
