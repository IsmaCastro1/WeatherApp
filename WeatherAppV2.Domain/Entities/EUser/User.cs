using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeatherAppV2.Domain.Entities.EUser;

public class User
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdUser { get; set; }
    [MaxLength(50)]
    public string? Name { get; set; }
    [MaxLength(50)]
    public string? LasName { get; set; }
    [MaxLength(64)]
    public string? Email { get; set; }
    [MaxLength(50)]
    public string? Username { get; set; }
}
