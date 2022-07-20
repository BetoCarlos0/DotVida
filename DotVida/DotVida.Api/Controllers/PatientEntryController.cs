using DotVida.Domain.Entities;
using DotVida.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DotVida.Api.Controllers
{
    [Route("api/pacientes")]
    [ApiController]
    public class PatientEntryController : ControllerBase
    {
        private readonly IPatientEntryRepository _repository;

        public PatientEntryController(IPatientEntryRepository patientEntryRepository)
        {
            _repository = patientEntryRepository;
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}/entradas")]
        public async Task<IEnumerable<PatientEntry>> GetAllEntryByIdAsync(Guid id)
        {
            return await _repository.GetAllByIdAsync(id);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost("entradas")]
        public async Task<IActionResult> PostPatientEntry(PatientEntry patient)
        {
            if (!ModelState.IsValid) return BadRequest(new ValidationProblemDetails(ModelState));

            await _repository.CreateAsync(patient);

            return Ok();
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpPut("entradas")]
        public async Task<IActionResult> PutPatientEntry(PatientEntry patient)
        {
            if (!ModelState.IsValid) return BadRequest(new ValidationProblemDetails(ModelState));

            await _repository.UpdateAsync(patient);

            return Ok();
        }

        [HttpGet("entradas/status")]
        public ActionResult<IEnumerable<string>> GetAllStatusEntry()
        {
            var status = new PatientEntry();
            return status.GetStatusEntry();
        }
    }
}
