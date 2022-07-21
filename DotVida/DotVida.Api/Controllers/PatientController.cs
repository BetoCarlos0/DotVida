using DotVida.Application.Interfaces;
using DotVida.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DotVida.Api.Controllers
{
    [Route("api/pacientes")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IAppPatientService _service;

        public PatientController(IAppPatientService patientService)
        {
            _service = patientService;
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Patient>>> GetAllPatients()
        {
            return Ok(await _service.GetAllAsync());
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public async Task<ActionResult<Patient>> GetByIdAsync(Guid id)
        {
            var patient = await _service.GetByIdAsync(id);

            if (patient == null)
                return NotFound("Paciente não encontrado");
            
            return Ok(patient);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        public async Task<IActionResult> PostPatient(Patient patient)
        {
            if (!ModelState.IsValid) return BadRequest(new ValidationProblemDetails(ModelState));

            await _service.CreateAsync(patient);

            return Ok();
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpPut]
        public async Task<IActionResult> PutPatient(Patient patient)
        {
            if (!ModelState.IsValid) return BadRequest(new ValidationProblemDetails(ModelState));

            await _service.UpdateAsync(patient);

            return Ok();
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePatient(Guid id)
        {
            if (!ModelState.IsValid) return BadRequest(new ValidationProblemDetails(ModelState));

            await _service.RemoveAsync(id);

            return Ok();
        }

        [HttpGet("bloodtypes")]
        public ActionResult<IEnumerable<string>> GetAllBloodType()
        {
            var bloodtypes = new Patient();
            return bloodtypes.GetBloodTypes();
        }

        [HttpGet("genders")]
        public ActionResult<IEnumerable<string>> GetAllGender()
        {
            var gender = new Patient();
            return gender.GetGenders();
        }
    }
}
