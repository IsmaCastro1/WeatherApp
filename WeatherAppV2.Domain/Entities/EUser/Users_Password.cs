using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAppV2.Domain.Entities.EUser;

public class Users_Password
{
    [Key]
    public int IdUser { get; set; }
    public String password { get; set; }

    [ForeignKey("IdUser")]
    public virtual User User { get; set; }
}
