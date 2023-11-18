using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherAppV2.Domain.Entities.EMunicipality;

namespace WeatherAppV2.Domain.Entities.EUser;

public class User_Municipalities
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public int IdUser { get; set; }
    public string CODIGOINE { get; set; }

    [ForeignKey("IdUser")]
    public virtual User user { get; set; }

    [ForeignKey("CODIGOINE")]
    public virtual Municipality municipality { get; set; }
}
