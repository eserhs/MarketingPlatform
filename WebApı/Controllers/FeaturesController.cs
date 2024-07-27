using Business.Abstract;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApı.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeaturesController : ControllerBase
    {
        IFeatureService _featureService;

        public FeaturesController(IFeatureService featureService)
        {
            _featureService = featureService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll() {
            var result = _featureService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        
        }

        [HttpGet("getbyid")]
        public IActionResult GetByİd(int id)
        {
            var result = _featureService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
                
            }
            return BadRequest(result);

        }

        [HttpPost("add")]
        public IActionResult Add(Feature feature) {
          var result = _featureService.Add(feature);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        
        }

        [HttpPost("Delete")]
        public IActionResult Delete(Feature feature)
        {
            var result = _featureService.Delete(feature);
            if (result.Success)

            {
                return Ok(result);
                
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(Feature feature)
        {
            var result = _featureService.Uptade(feature);
            if (result.Success)
            {
                return Ok(result);
                
            }
            return BadRequest(result);
        }

    }
}
