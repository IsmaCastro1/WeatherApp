using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WeatherAppV2.Domain.Entities.EProvince;

public partial class Province
{
    [Key]
    public string Codprov { get; set; } = null!;

    public string? NombreProvincia { get; set; }

    public string? ComunidadCiudadAutonoma { get; set; }

    public string? CapitalProvincia { get; set; }

    public string? Codauton { get; set; }
}
