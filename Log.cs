using System.Text.Json.Serialization;

namespace PlantControl.Models;

public class Log
{
    [JsonPropertyName("temperature")] public double Temperature { get; set; }

    [JsonPropertyName("humidity")] public double Humidity { get; set; }

    [JsonPropertyName("moisture")] public double Moisture { get; set; }

    [JsonPropertyName("pairing")] public string Pairing { get; set; }

    [JsonPropertyName("_id")] public string Id { get; set; }

    [JsonPropertyName("time")] public DateTimeOffset Time { get; set; }

    [JsonPropertyName("__v")] public long V { get; set; }
}