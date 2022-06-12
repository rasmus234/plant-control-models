using System.Text.Json.Serialization;

namespace PlantControl.Models;

public class Log
{
    [JsonPropertyName("temperature")] public long Temperature { get; set; }

    [JsonPropertyName("humidity")] public long Humidity { get; set; }

    [JsonPropertyName("moisture")] public long Moisture { get; set; }

    [JsonPropertyName("pairing")] public string Pairing { get; set; }

    [JsonPropertyName("_id")] public string Id { get; set; }

    [JsonPropertyName("time")] public DateTimeOffset Time { get; set; }

    [JsonPropertyName("__v")] public long V { get; set; }
}