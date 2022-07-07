using System.ComponentModel;

namespace DotVida.Domain.Entities.Enums
{
    public enum StatusSick
    {
        [Description("Curado")]
        curado,
        [Description("Doente")]
        doente,
        [Description("Em tratamento")]
        tratamento
    }
}
