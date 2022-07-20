using DotVida.Domain.Entities;
using DotVida.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DotVida.Api.Controllers
{
    [Route("api/pacientes/entradas")]
    [ApiController]
    public class PatientEntryController : ControllerBase
    {
        private readonly IPatientEntryRepository _patientEntryRepository;

        public PatientEntryController(IPatientEntryRepository patientEntryRepository)
        {
            _patientEntryRepository = patientEntryRepository;
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public async Task<IEnumerable<PatientEntry>> GetAllEntryByIdAsync(Guid id)
        {
            return await _patientEntryRepository.GetAllByIdAsync(id);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        public async Task<IActionResult> PostPatientEntry(PatientEntry patient)
        {
            if (!ModelState.IsValid) return BadRequest(new ValidationProblemDetails(ModelState));

            await _patientEntryRepository.CreateAsync(patient);

            return Ok();
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpPut]
        public async Task<IActionResult> PutPatientEntry(PatientEntry patient)
        {
            if (!ModelState.IsValid) return BadRequest(new ValidationProblemDetails(ModelState));

            await _patientEntryRepository.UpdateAsync(patient);

            return Ok();
        }

        [HttpGet("status")]
        public ActionResult<IEnumerable<string>> GetAllStatusEntry()
        {
            var status = new PatientEntry();
            return status.GetStatusEntry();
        }
    }
}
