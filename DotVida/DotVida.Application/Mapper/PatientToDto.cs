using AutoMapper;
using DotVida.Application.Dtos;
using DotVida.Domain.Entities;

namespace DotVida.Application.Mapper
{
    public class PatientToDto : Profile
    {
        public PatientToDto()
        {
            PatientDtoMap();
        }

        private void PatientDtoMap()
        {
            CreateMap<Patient, PatientDto>()
                .ForMember(x => x.Id, x => x.MapFrom(x => x.Id))
                .ForMember(x => x.Name, x => x.MapFrom(x => x.Name))
                .ForMember(x => x.Age, x => x.MapFrom(x => x.Age))
                .ForMember(x => x.CPF, x => x.MapFrom(x => x.CPF))
                .ForMember(x => x.Gender, x => x.MapFrom(x => x.Gender))
                .ForMember(x => x.BloodType, x => x.MapFrom(x => x.BloodType))
                .ForMember(x => x.PersonStatus, x => x.MapFrom(x => x.PersonStatus))
                .ReverseMap();
        }
    }
}
