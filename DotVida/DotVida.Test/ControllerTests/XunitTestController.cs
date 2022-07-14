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
        private readonly Mock<IPatientRepository> _repositoryMock = new();

        [Fact, Trait("Patient", "GetAllPatients")]
        public async Task GetAllEntities_WhenCalled_ReturnEmpty()
        {
            _repositoryMock.Setup(x => x.GetAllAsync());
            var controller = new PatientController(_repositoryMock.Object);

            var patient = await controller.GetAllPatients();

            var result = patient.Result;
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact, Trait("Patient", "GetPatient")]
        public async Task GetEntity_WhenCalled_ReturnNotFound()
        {
            _repositoryMock.Setup(x => x.GetByIdAsnc(It.IsAny<Guid>()));
            var controller = new PatientController(_repositoryMock.Object);

            var id = new Guid("ff62f258-8337-4d95-9460-5b0078447a62");
            var patient = await controller.GetPatient(id);

            var result = patient.Result;
            Assert.IsType<NotFoundObjectResult>(result);
        }

        [Fact, Trait("Patient", "PostPatient")]
        public async Task GetEntity_LabelEmpty_ReturnBadRequest()
        {
            var newPatient = new Patient
            {
                Id = new Guid("d9dd53b0-0529-4c7c-a586-091105cb67f9"),
                //Name = "teste 1",
                CPF = "321.654.987-54",
                Age = 34,
                Gender = "homem cis",
                BloodType = "A+",
                PersonStatus = true
            };
            _repositoryMock.Setup(x => x.CreateAsync(newPatient));
            var controller = new PatientController(_repositoryMock.Object);
            controller.ModelState.AddModelError("Name", "Required");

            var patient = await controller.PostPatient(newPatient);

            Assert.IsType<BadRequestObjectResult>(patient);
        }

        [Fact, Trait("Patient", "PostPatient")]
        public async Task GetEntity_WhenCalled_ReturnOk()
        {
            var newPatient = new Patient
            {
                Id = new Guid("d9dd53b0-0529-4c7c-a586-091105cb67f9"),
                Name = "teste 1",
                CPF = "321.654.987-54",
                Age = 34,
                Gender = "homem cis",
                BloodType = "A+",
                PersonStatus = true
            };
            _repositoryMock.Setup(x => x.CreateAsync(newPatient));
            var controller = new PatientController(_repositoryMock.Object);

            var patient = await controller.PostPatient(newPatient);

            Assert.IsType<OkResult>(patient);
        }

        [Fact, Trait("Patient", "PutPatient")]
        public async Task GetEntity_WhenCalled_ReturnBadRequest()
        {
            var newPatient = new Patient
            {
                Name = "teste 1",
                CPF = "321.654.987-54",
                Age = 34,
                Gender = "homem cis",
                BloodType = "A+",
                PersonStatus = true
            };
            _repositoryMock.Setup(x => x.UpdateAsync(newPatient));
            var controller = new PatientController(_repositoryMock.Object);

            var patient = await controller.PutPatient(newPatient);

            Assert.IsType<OkResult>(patient);
        }
    }
}
