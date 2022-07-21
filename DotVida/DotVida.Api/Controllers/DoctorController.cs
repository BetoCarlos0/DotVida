using DotVida.Application.Interfaces;
using DotVida.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DotVida.Api.Controllers
{
    [Route("api/doutores")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IAppDoctorService _service;

        public DoctorController(IAppDoctorService doctorRepository)
        {
            _service = doctorRepository;
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Doctor>>> GetAllDoctor()
        {
            return Ok(await _service.GetAllAsync());
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public async Task<ActionResult<Doctor>> GetByIdAsync(Guid id)
        {
            var doctor = await _service.GetByIdAsync(id);

            if (doctor == null)
                return NotFound("Doutor não encontrado");

            return Ok(doctor);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        public async Task<IActionResult> PostDoctor(Doctor doctor)
        {
            if (!ModelState.IsValid) return BadRequest(new ValidationProblemDetails(ModelState));

            await _service.CreateAsync(doctor);

            return Ok();
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpPut]
        public async Task<IActionResult> PutDoctor(Doctor doctor)
        {
            if (!ModelState.IsValid) return BadRequest(new ValidationProblemDetails(ModelState));

            await _service.UpdateAsync(doctor);

            return Ok();
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDoctor(Guid id)
        {
            if (!ModelState.IsValid) return BadRequest(new ValidationProblemDetails(ModelState));

            await _service.RemoveAsync(id);

            return Ok();
        }
    }
}
