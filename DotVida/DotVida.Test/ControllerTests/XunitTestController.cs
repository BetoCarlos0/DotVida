using DotVida.Api.Controllers;
using DotVida.Domain.Entities;
using DotVida.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace DotVida.Test.ControllerTests
{
    public class XunitTestController
    {
        [Fact, Trait("Patient", "GetAll")]
        public async Task GetAllEntities_WhenCalled_ReturnEmpty()
        {
            var mockRepository = new Mock<IPatientRepository>();
            mockRepository.Setup(x => x.GetAllAsync());
            var controller = new PatientController(mockRepository.Object);

            var patient = await controller.GetAllPatients();

            var result = patient.Result;
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact, Trait("Patient", "GetById")]
        public async Task GetEntity_WhenCalled_ReturnNotFound()
        {
            var mockRepository = new Mock<IPatientRepository>();
            mockRepository.Setup(x => x.GetByIdAsnc(It.IsAny<Guid>())).ThrowsAsync(new DbUpdateException());
            var controller = new PatientController(mockRepository.Object);

            var id = new Guid("ff62f258-8337-4d95-9460-5b0078447a62");

            var patient = await controller.GetPatient(id);

            var result = patient.Result;
            Assert.IsType<NotFoundResult>(result);
        }
    }
}
