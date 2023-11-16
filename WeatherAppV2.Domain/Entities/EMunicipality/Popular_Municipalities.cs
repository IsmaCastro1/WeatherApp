using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WeatherAppV2.Domain.Entities.EMunicipality;

public class Popular_Municipalities
{
    [Key]
    public String CODIGOINE { get; set; }

    [ForeignKey(nameof(CODIGOINE))]
    public virtual Municipality municipality { get; set; }

}
