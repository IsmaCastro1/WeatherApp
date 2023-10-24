using System;
using System.Collections.Generic;

namespace WeatherAppV2.Domain;

public partial class Province
{
    public string Codprov { get; set; } = null!;

    public string? NombreProvincia { get; set; }

    public string? ComunidadCiudadAutonoma { get; set; }

    public string? CapitalProvincia { get; set; }

    public string? Codauton { get; set; }
}
