﻿using DotVida.Domain.Entities;

namespace DotVida.Application.Interfaces
{
    public interface IAppPatientEntryService : IAppServiceBase<PatientEntry>
    {
        Task<IEnumerable<PatientEntry>> GetAllByIdAsync(Guid id);
    }
}