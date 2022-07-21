using DotVida.Application.Interfaces;
using DotVida.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DotVida.Api.Controllers
{
    [Route("api/pacientes/entradas")]
    [ApiController]
    public class AttendanceController : ControllerBase
    {
        private readonly IAppAttendanceService _service;

        public AttendanceController(IAppAttendanceService attendanceService)
        {
            _service = attendanceService;
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}/atendimentos")]
        public async Task<IEnumerable<Attendance>> GetAllAttendanceByIdAsync(Guid id)
        {
            return await _service.GetAllByIdAsync(id);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost("atendimentos")]
        public async Task<IActionResult> PostAttendance(Attendance attendance)
        {
            if (!ModelState.IsValid) return BadRequest(new ValidationProblemDetails(ModelState));

            await _service.CreateAsync(attendance);

            return Ok();
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpPut("atendimentos")]
        public async Task<IActionResult> PutAttendance(Attendance attendance)
        {
            if (!ModelState.IsValid) return BadRequest(new ValidationProblemDetails(ModelState));

            await _service.UpdateAsync(attendance);

            return Ok();
        }
    }
}
