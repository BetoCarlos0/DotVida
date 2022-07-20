using DotVida.Domain.Entities;
using DotVida.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DotVida.Api.Controllers
{
    [Route("api/pacientes")]
    [ApiController]
    public class PersonalSickController : ControllerBase
    {
        private readonly IPersonalSickRepository _repository;

        public PersonalSickController(IPersonalSickRepository repository)
        {
            _repository = repository;
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}/enfermidade-pessoal")]
        public async Task<IEnumerable<PersonalSick>> GetAllEntryByIdAsync(Guid id)
        {
            return await _repository.GetAllByIdAsync(id);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost("enfermidade-pessoal")]
        public async Task<IActionResult> PostPatientEntry(PersonalSick personal)
        {
            if (!ModelState.IsValid) return BadRequest(new ValidationProblemDetails(ModelState));

            await _repository.CreateAsync(personal);

            return Ok();
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpPut("enfermidade-pessoal")]
        public async Task<IActionResult> PutPatientEntry(PersonalSick personal)
        {
            if (!ModelState.IsValid) return BadRequest(new ValidationProblemDetails(ModelState));

            await _repository.UpdateAsync(personal);

            return Ok();
        }

        [HttpGet("enfermidade-pessoal/status")]
        public ActionResult<IEnumerable<string>> GetAllStatusSick()
        {
            var status = new PersonalSick();
            return status.GetStatusSick();
        }

        [HttpGet("enfermidade-pessoal/tipo")]
        public ActionResult<IEnumerable<string>> GetAllTypeSick()
        {
            var status = new Sick();
            return status.GetTypeSick();
        }
    }
}
