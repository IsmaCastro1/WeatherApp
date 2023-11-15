using System.ComponentModel.DataAnnotations;

namespace WeatherAppV2.WebApp.Models.ViewModels;

public class UserView
{
    public int id { get; set; }

    [Required(ErrorMessage = "El Nombre es obligatorio")]
	[MinLength(4, ErrorMessage = "Debe tener minimo 4 caracteres")]
	[MaxLength(50, ErrorMessage = "Debe tener maximo 50 caracteres")]
	public string? Name { get; set; }


	[Required(ErrorMessage = "El apellido es obligatorio")]
	[MinLength(4, ErrorMessage = "Debe tener minimo 4 caracteres")]
	[MaxLength(50, ErrorMessage = "Debe tener maximo 50 caracteres")]
	public string? LasName { get; set; }


	[Required(ErrorMessage = "El email es obligatorio")]
	[EmailAddress(ErrorMessage ="Formato Correo Incorrecto")]
	public string? Email { get; set; }


	[Required(ErrorMessage ="El usuario es obligatorio")]
	[MinLength(5, ErrorMessage = "Debe tener minimo 5 caracteres")]
	[MaxLength(50, ErrorMessage = "Debe tener maximo 50 caracteres")]
	public string? Username { get; set; }


	[Required (ErrorMessage ="La Contraseña es obligatoria")]
	//[RegularExpression(@"(?=.{6,})(?=(.*\d){1,})(?=(.*\W){1,})", ErrorMessage = "La contraseña debe tener al menos 6 caracteres y contener al menos un número y un carácter especial.")]
	public String Password { get; set; }

}
