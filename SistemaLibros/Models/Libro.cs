using System;
using System.Collections.Generic;

namespace SistemaLibros.Models;

public partial class Libro
{
    public int IdLibro { get; set; }

    public string TituloLibro { get; set; } = null!;

    public string AutorLibro { get; set; } = null!;

    public string DescripcionLibro { get; set; } = null!;

    public int NumejemplaresLibro { get; set; }

    public string ImagenLibro { get; set; } = null!;
}
