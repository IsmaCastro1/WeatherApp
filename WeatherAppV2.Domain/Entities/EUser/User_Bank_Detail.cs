using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAppV2.Domain.Entities.EUser;

public class User_Bank_Detail
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public int IdUser { get; set; }

    [MaxLength(100)]
    public String Entity;

    public int Card_Number { get; set; }
    public DateTime Expiry_Date { get; set; }

    [ForeignKey("IdUser")]
    public virtual User User { get; set; }
}
