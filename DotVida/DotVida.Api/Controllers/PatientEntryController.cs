using DotVida.Application.Interfaces;
using DotVida.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DotVida.Api.Controllers
{
    [Route("api/pacientes")]
    [ApiController]
    public class PatientEntryController : ControllerBase
    {
        private readonly IAppPatientEntryService _service;

        public PatientEntryController(IAppPatientEntryService patientEntryService)
        {
            _service = patientEntryService;
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}/entradas")]
        public async Task<IEnumerable<PatientEntry>> GetAllEntryByIdAsync(Guid id)
        {
            return await _service.GetAllByIdAsync(id);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost("entradas")]
        public async Task<IActionResult> PostPatientEntry(PatientEntry patient)
        {
            if (!ModelState.IsValid) return BadRequest(new ValidationProblemDetails(ModelState));

            await _service.CreateAsync(patient);

            return Ok();
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpPut("entradas")]
        public async Task<IActionResult> PutPatientEntry(PatientEntry patient)
        {
            if (!ModelState.IsValid) return BadRequest(new ValidationProblemDetails(ModelState));

            await _service.UpdateAsync(patient);

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
