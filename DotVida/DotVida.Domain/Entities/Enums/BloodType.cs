using System.ComponentModel;

namespace DotVida.Domain.Entities.Enums
{
    public enum BloodType
    {
        [Description("A+")]
        AP,
        [Description("A-")]
        AL,
        [Description("B+")]
        BP,
        [Description("B-")]
        BL,
        [Description("AB+")]
        ABP,
        [Description("AB-")]
        ABL,
        [Description("O+")]
        OP,
        [Description("O-")]
        OL,
    }
}
