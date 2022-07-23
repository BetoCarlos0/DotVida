using AutoMapper;
using DotVida.Application.Dtos;
using DotVida.Domain.Entities;

namespace DotVida.Application.Mapper
{
    public class DtoToPatient : Profile
    {
        public DtoToPatient()
        {
            PatientMap();
        }

        private void PatientMap()
        {
            CreateMap<Patient, PatientDto>()
                .ForMember(x => x.Id, x => x.MapFrom(x => x.Id))
                .ForMember(x => x.Name, x => x.MapFrom(x => x.Name))
                .ForMember(x => x.CPF, x => x.MapFrom(x => x.CPF))
                .ForMember(x => x.Gender, x => x.MapFrom(x => x.Gender))
                .ForMember(x => x.PersonStatus, x => x.MapFrom(x => x.PersonStatus));
        }
    }
}
