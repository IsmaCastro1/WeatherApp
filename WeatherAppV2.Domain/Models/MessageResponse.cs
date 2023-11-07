namespace WeatherAppV2.WebApp.Domain.Models;

public class MessageReponse<T>
{
    public String code { get; set; }
    public T data { get; set; }
}
