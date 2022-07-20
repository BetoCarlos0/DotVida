using DotVida.Domain.Entities;
using DotVida.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DotVida.Api.Controllers
{
    [Route("api/pacientes/entradas")]
    [ApiController]
    public class AttendanceController : ControllerBase
    {
        private readonly IAttendanceRepository _repository;

        public AttendanceController(IAttendanceRepository attendanceRepository)
        {
            _repository = attendanceRepository;
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}/atendimentos")]
        public async Task<IEnumerable<Attendance>> GetAllAttendanceByIdAsync(Guid id)
        {
            return await _repository.GetAllByIdAsync(id);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost("atendimentos")]
        public async Task<IActionResult> PostAttendance(Attendance attendance)
        {
            if (!ModelState.IsValid) return BadRequest(new ValidationProblemDetails(ModelState));

            await _repository.CreateAsync(attendance);

            return Ok();
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpPut("atendimentos")]
        public async Task<IActionResult> PutAttendance(Attendance attendance)
        {
            if (!ModelState.IsValid) return BadRequest(new ValidationProblemDetails(ModelState));

            await _repository.UpdateAsync(attendance);

            return Ok();
        }
    }
}
