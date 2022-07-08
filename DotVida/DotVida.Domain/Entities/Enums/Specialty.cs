using System.ComponentModel;

namespace DotVida.Domain.Entities.Enums
{
    public enum Specialty
    {
        [Description("Cardiologista")]
        card,
        [Description("Dermatologista")]
        derma,
        [Description("Ginecologista e Obstetrícista")]
        gineObste,
        [Description("Ortopedista")]
        orto,
        [Description("Anestesiologista")]
        aneste,
        [Description("Pediatra")]
        pedia,
        [Description("Oftamologista")]
        oftamo,
        [Description("Psiquiatra")]
        psiqui,
        [Description("Urologista")]
        urolo,
        [Description("Oncologista")]
        oncolo,
        [Description("Endocrinologista")]
        endo,
        [Description("Neorologista")]
        neoro,
        [Description("Hematologista")]
        hemato,
        [Description("Cirurgião Plático")]
        cirur
    }
}
