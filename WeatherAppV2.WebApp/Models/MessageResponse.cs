namespace WeatherAppV2.WebApp.Models;

public class MessageReponse<T>
{
    private  String code { get; set; }
    private  T data{ get; set; }
}
