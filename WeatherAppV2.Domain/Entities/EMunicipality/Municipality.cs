using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WeatherAppV2.Domain.Entities.EMunicipality;

public class Municipality
{
    [Key]
    public string Codigoine { get; set; } 

    public string IdRel { get; set; } 

    public string CodGeo { get; set; } 

    public string Codprov { get; set; } 

    public string NombreProvincia { get; set; } 

    public string Nombre { get; set; } 

    public int PoblacionMuni { get; set; }

    public float Superficie { get; set; }

    public int Perimetro { get; set; }

    public string CodigoineCapital { get; set; } 

    public string NombreCapital { get; set; } 

    public string PoblacionCapital { get; set; } 

    public string HojaMtn25 { get; set; } 

    public float LongitudEtrs89Regcan95 { get; set; }

    public float LatitudEtrs89Regcan95 { get; set; }

    public string OrigenCoord { get; set; } 

    public int Altitud { get; set; }

    public string OrigenAltitud { get; set; } 

    public int DiscrepanteIne { get; set; }
}
