using System.Text.Json.Serialization;

namespace PlantControl.Models;

public class Config
{
    [JsonPropertyName("Logging")] public Logging Logging { get; set; }

    [JsonPropertyName("Air")] public Air Air { get; set; }

    [JsonPropertyName("Soil")] public Soil Soil { get; set; }
}

public class Air
{
    [JsonPropertyName("MinHumid")] public double MinHumid { get; set; }

    [JsonPropertyName("MaxHumid")] public double MaxHumid { get; set; }

    [JsonPropertyName("MinTemp")] public double MinTemp { get; set; }

    [JsonPropertyName("MaxTemp")] public double MaxTemp { get; set; }
}

public class Logging
{
    [JsonPropertyName("LoggerId")] public string LoggerId { get; set; }

    [JsonPropertyName("PairingId")] public string PairingId { get; set; }

    [JsonPropertyName("Active")] public bool Active { get; set; }

    [JsonPropertyName("SocketUrl")] public string SocketUrl { get; set; }

    [JsonPropertyName("RestUrl")] public string RestUrl { get; set; }
}

public class Soil
{
    [JsonPropertyName("Moist")] public double Moist { get; set; }

    [JsonPropertyName("Dry")] public double Dry { get; set; }
}