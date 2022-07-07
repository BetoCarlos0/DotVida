using System.ComponentModel;

namespace DotVida.Domain.Entities.Enums
{
    public enum Gender
    {
        [Description("Homem cis")]
        Homem_cis,
        [Description("Mulher cis")]
        Mulher_cis,
        [Description("Homem trans")]
        Homem_trans,
        [Description("Mulher trans")]
        Mulher_trans,
        [Description("Outro")]
        Outro
    }
}
