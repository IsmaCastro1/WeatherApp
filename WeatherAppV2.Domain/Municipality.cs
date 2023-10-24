using System;
using System.Collections.Generic;

namespace WeatherAppV2.Domain;

public partial class Municipality
{
    public string Codigoine { get; set; } = null!;

    public string IdRel { get; set; } = null!;

    public string CodGeo { get; set; } = null!;

    public string Codprov { get; set; } = null!;

    public string NombreProvincia { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public int PoblacionMuni { get; set; }

    public float Superficie { get; set; }

    public int Perimetro { get; set; }

    public string CodigoineCapital { get; set; } = null!;

    public string NombreCapital { get; set; } = null!;

    public string PoblacionCapital { get; set; } = null!;

    public string HojaMtn25 { get; set; } = null!;

    public float LongitudEtrs89Regcan95 { get; set; }

    public float LatitudEtrs89Regcan95 { get; set; }

    public string OrigenCoord { get; set; } = null!;

    public int Altitud { get; set; }

    public string OrigenAltitud { get; set; } = null!;

    public int DiscrepanteIne { get; set; }
}
