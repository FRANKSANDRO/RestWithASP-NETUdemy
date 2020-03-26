using Microsoft.AspNetCore.Mvc;
using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Business;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Controllers
{

    [ApiVersion("1")]
    [Route("api/[controller]/v{version:apiVersion}")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private IPersonBusiness _personBusiness;

        public PersonsController(IPersonBusiness personService)
        {
            _personBusiness = personService;
        }

        // GET api/values
        [HttpGet("v1")]
        public ActionResult<List<Persons>> Get()
        {
            return Ok(_personBusiness.FindAll());
        }

        // GET api/values/5
        [HttpGet("v1/{id}")]
        public ActionResult<Persons> Get(long id)
        {
            var person = _personBusiness.FindById(id);
            if (person == null)
            {
                return NotFound();
            }

            return Ok(person);
        }

        // POST api/values
        [HttpPost("v1")]
        public IActionResult Post([FromBody] Persons person)
        {           
            if (person == null)
            {
                return BadRequest();
            }

            return new ObjectResult(_personBusiness.Create(person));
        }

        // PUT api/values/5
        [HttpPut("v1")]
        public IActionResult Put([FromBody] Persons person)
        {
            if (person == null)
            {
                return BadRequest();
            }

            return new ObjectResult(_personBusiness.Update(person));
        }

        // DELETE api/values/5
        [HttpDelete("v1/{id}")]
        public IActionResult Delete(long id)
        {
            _personBusiness.Delete(id);

            return NoContent();
        }
    }
}
