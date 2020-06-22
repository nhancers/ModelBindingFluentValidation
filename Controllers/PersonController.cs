using Microsoft.AspNetCore.Mvc;

namespace FluentValidationSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] Person person)
        {
            // //Validate binding errors.
            // if (!ModelState.IsValid)
            //     return BadRequest(ModelState.Values);

            //Validate.
            var valdiationResult = new PersonValidator().Validate(person);

            if (!valdiationResult.IsValid)
                return BadRequest(valdiationResult.Errors);

            //Rest of work.
            return Ok(person);
        }
    }
}
