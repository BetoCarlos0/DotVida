using AutoMapper;
using DotVida.Application.Dtos;
using DotVida.Domain.Entities;

namespace DotVida.Application.Mapper
{
    public class DtoToDoctor : Profile
    {
        public DtoToDoctor()
        {
            DtoDoctorMap();
        }

        private void DtoDoctorMap()
        {
            CreateMap<DoctorNewDto, Doctor>()
                .ForMember(x => x.Id, x => x.MapFrom(x => x.Id))
                .ForMember(x => x.Name, x => x.MapFrom(x => x.Name))
                .ForMember(x => x.CPF, x => x.MapFrom(x => x.CPF))
                .ForMember(x => x.Gender, x => x.MapFrom(x => x.Gender))
                .ForMember(x => x.PersonStatus, x => x.MapFrom(x => x.PersonStatus))
                .ForMember(x => x.EmployeeStatus, x => x.MapFrom(x => x.EmployeeStatus))
                .ForMember(x => x.RegistrationNumber, x => x.MapFrom(x => x.RegistrationNumber))
                .ForMember(x => x.Login, x => x.MapFrom(x => x.Login))
                .ForMember(x => x.Password, x => x.MapFrom(x => x.Password))
                .ForMember(x => x.Specialty, x => x.MapFrom(x => x.Specialty));
        }
    }
}
