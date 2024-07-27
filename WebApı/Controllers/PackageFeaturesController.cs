using Business.Abstract;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApı.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PackageFeaturesController : ControllerBase
    {
        IPackageFeatureService _packageFeatureService;

        public PackageFeaturesController(IPackageFeatureService packageFeatureService)
        {
            _packageFeatureService = packageFeatureService;
        }


        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result= _packageFeatureService.GetAll();    
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetByİd(int id) {
        var result = _packageFeatureService.GetById(id);
            if (result.Success) { 
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbypackageid")]
        public IActionResult GetByPackageId(int id) {
        var result = _packageFeatureService.GetByPackageId(id);
            if (result.Success)
            {
                return Ok(result);
                
            }
            return BadRequest(result);
        }

        [HttpGet("getbyfeatureid")]
        public IActionResult GetByFeatureId(int id) {
            var result = _packageFeatureService.GetByFeatureId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        
        
        }
        [HttpPost("add")]
        public IActionResult Add(PackageFeature packageFeature) {
        var result = _packageFeatureService.Add(packageFeature);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        
        }
        [HttpPost("delate")]
        public IActionResult Delete(PackageFeature packageFeature)
        {
            var result = _packageFeatureService.Delete(packageFeature);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpPost("update")]
        public IActionResult Update(PackageFeature packageFeature)
        {
            var result = _packageFeatureService.Update(packageFeature);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }





    }
}
