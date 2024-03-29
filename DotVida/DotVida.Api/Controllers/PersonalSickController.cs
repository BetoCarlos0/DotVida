﻿using DotVida.Application.Interfaces;
using DotVida.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DotVida.Api.Controllers
{
    [Route("api/pacientes")]
    [ApiController]
    public class PersonalSickController : ControllerBase
    {
        private readonly IAppPersonalSickService _service;

        public PersonalSickController(IAppPersonalSickService personalSickService)
        {
            _service = personalSickService;
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}/enfermidade-pessoal")]
        public async Task<IEnumerable<PersonalSick>> GetAllEntryByIdAsync(Guid id)
        {
            return await _service.GetAllByIdAsync(id);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost("enfermidade-pessoal")]
        public async Task<IActionResult> PostPatientEntry(PersonalSick personal)
        {
            if (!ModelState.IsValid) return BadRequest(new ValidationProblemDetails(ModelState));

            await _service.CreateAsync(personal);

            return Ok();
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpPut("enfermidade-pessoal")]
        public async Task<IActionResult> PutPatientEntry(PersonalSick personal)
        {
            if (!ModelState.IsValid) return BadRequest(new ValidationProblemDetails(ModelState));

            await _service.UpdateAsync(personal);

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
