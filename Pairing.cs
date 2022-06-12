using System.Text.Json.Serialization;

namespace PlantControl.Models;

public class Pairing
{
    [JsonPropertyName("_id")] public string Id { get; set; }

    [JsonPropertyName("name")] public string Name { get; set; }

    [JsonPropertyName("plant")] public Plant Plant { get; set; }

    [JsonPropertyName("logger")] public Logger Logger { get; set; }

    [JsonPropertyName("createdAt")] public DateTimeOffset CreatedAt { get; set; }

    [JsonPropertyName("__v")] public long V { get; set; }
}