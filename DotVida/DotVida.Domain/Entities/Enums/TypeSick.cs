using System.ComponentModel;

namespace DotVida.Domain.Entities.Enums
{
    public enum TypeSick
    {
        [Description("Anomalia")]
        anomalia,
        [Description("Deficiência")]
        deficiencia,
        [Description("Alergia")]
        alergia,
        [Description("Crônica")]
        cronica,
        [Description("Comum")]
        comum
    }
}
