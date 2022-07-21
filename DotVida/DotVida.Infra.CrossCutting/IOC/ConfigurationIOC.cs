using Autofac;
using DotVida.Application;
using DotVida.Application.Interfaces;
using DotVida.Domain.Interfaces.Repositoies;
using DotVida.Domain.Interfaces.Services;
using DotVida.Domain.Services;
using DotVida.Infra.Data.Repositories;

namespace DotVida.Infra.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AppAttendanceService>().As<IAppAttendanceService>();
            builder.RegisterType<AppDoctorService>().As<IAppDoctorService>();
            builder.RegisterType<AppPatientEntryService>().As<IAppPatientEntryService>();
            builder.RegisterType<AppPatientService>().As<IAppPatientService>();
            builder.RegisterType<AppPersonalSickService>().As<IAppPersonalSickService>();
            builder.RegisterType<AppSickService>().As<IAppSickService>();

            builder.RegisterType<AttendanceService>().As<IAttendanceService>();
            builder.RegisterType<DoctorService>().As<IDoctorService>();
            builder.RegisterType<PatientEntryService>().As<IPatientEntryService>();
            builder.RegisterType<PatientService>().As<IPatientService>();
            builder.RegisterType<PersonalSickService>().As<IPersonalSickService>();
            builder.RegisterType<SickService>().As<ISickService>();

            builder.RegisterType<AttendanceRepository>().As<IAttendanceRepository>();
            builder.RegisterType<DoctorRepository>().As<IDoctorRepository>();
            builder.RegisterType<PatientEntryRepository>().As<IPatientEntryRepository>();
            builder.RegisterType<PatientRepository>().As<IPatientRepository>();
            builder.RegisterType<PersonalSickRepository>().As<IPersonalSickRepository>();
            builder.RegisterType<SickRepository>().As<ISickRepository>();
        }
    }
}
