﻿using DotVida.Domain.Entities.Abstracts;
using System.ComponentModel.DataAnnotations;

namespace DotVida.Domain.Entities
{
    public class Doctor : EmployeeBase
    {
        [Required(ErrorMessage = "Número de registro vazio")]
        [RegularExpression(@"[0-9]{6}[C][R][M][/]+([A][CLPM]|[C][E]|[D][F]|[E][S]|[G][O]|[M][TSG]|[BMP][A]|[P][BREI]|[R][JNSOR]|[S][CPE]|[T][O])"
            , ErrorMessage = "Formato inválido")]
        public string? RegistrationNumber { get; set; }

        [Required(ErrorMessage = "Especialização vazia")]
        public string? Specialty { get; set; }

        public List<string> GetSpecialty()
        {
            return new List<string> { "Cardiologista", "Dermatologista", "Ginecologista e Obstetrícista",
                                    "Ortopedista", "Anestesiologista", "Pediatra", "Oftamologista", "Psiquiatra",
                                    "Urologista", "Oncologista", "Endocrinologista", "Neorologista", "Hematologista",
                                    "Cirurgião Plático"};
        }
    }
}
