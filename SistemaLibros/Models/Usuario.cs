using System;
using System.Collections.Generic;

namespace SistemaLibros.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string NombreUsuario { get; set; } = null!;

    public string AliasUsuario { get; set; } = null!;

    public string ContraseniaUsuario { get; set; } = null!;

    public int RolidUsuario { get; set; }

    public virtual Role RolidUsuarioNavigation { get; set; } = null!;
}
