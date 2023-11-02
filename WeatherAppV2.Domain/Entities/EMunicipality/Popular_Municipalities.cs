using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAppV2.Domain.Entities.EMunicipality;

public class Popular_Municipalities
{
    [Key]
    public String CODIGOINE { get; set; }

    [ForeignKey(nameof(CODIGOINE))]
    public Municipality municipality { get; set; }

}
