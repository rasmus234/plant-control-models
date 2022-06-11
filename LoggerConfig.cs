namespace PlantControl.Models;

public class LoggerConfig
{
    public Logging Logging { get; set; }
    public Air Air { get; set; }
    public Soil Soil { get; set; }
}

public record Logging(string LoggerId, bool Active, string SocketUrl, string RestUrl, string PairingId)
{
    public string LoggerId { get; } = LoggerId;
    public bool Active { get; } = Active;
    public string SocketUrl { get; } = SocketUrl;
    public string RestUrl { get; } = RestUrl;
    public string PairingId { get; } = PairingId;
}

public record Air(float MinHumid, float MaxHumid, float MinTemp, float MaxTemp)
{
    public float MinHumid { get; set; } = MinHumid;
    public float MaxHumid { get; set; } = MaxHumid;
    public float MinTemp { get; set; } = MinTemp;
    public float MaxTemp { get; set; } = MaxTemp;
}

public record Soil(float Moist, float Dry)
{
    public float Moist { get; set; } = Moist;
    public float Dry { get; set; } = Dry;
}