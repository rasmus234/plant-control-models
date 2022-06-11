using Newtonsoft.Json;

namespace PlantControl.Models;

public class Config
{
    [JsonProperty("Logging")] public Logging Logging { get; set; }

    [JsonProperty("Air")] public Air Air { get; set; }

    [JsonProperty("Soil")] public Soil Soil { get; set; }
}

public class Air
{
    [JsonProperty("MinHumid")] public long MinHumid { get; set; }

    [JsonProperty("MaxHumid")] public long MaxHumid { get; set; }

    [JsonProperty("MinTemp")] public long MinTemp { get; set; }

    [JsonProperty("MaxTemp")] public long MaxTemp { get; set; }
}

public class Logging
{
    [JsonProperty("LoggerId")] public string LoggerId { get; set; }

    [JsonProperty("PairingId")] public string PairingId { get; set; }

    [JsonProperty("Active")] public bool Active { get; set; }

    [JsonProperty("SocketUrl")] public string SocketUrl { get; set; }

    [JsonProperty("RestUrl")] public string RestUrl { get; set; }
}

public class Soil
{
    [JsonProperty("Moist")] public double Moist { get; set; }

    [JsonProperty("Dry")] public double Dry { get; set; }
}