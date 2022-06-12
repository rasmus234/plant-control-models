using System.Text.Json.Serialization;

namespace PlantControl.Models;

public class Certificate
{
    [JsonPropertyName("plant")] public Plant Plant { get; set; }

    [JsonPropertyName("temperature")] public Data Temperature { get; set; }

    [JsonPropertyName("humidity")] public Data Humidity { get; set; }

    [JsonPropertyName("moisture")] public Data Moisture { get; set; }

    [JsonPropertyName("_id")] public string Id { get; set; }

    [JsonPropertyName("createdAt")] public DateTimeOffset CreatedAt { get; set; }

    [JsonPropertyName("__v")] public long V { get; set; }
}

public class Data
{
    [JsonPropertyName("avg")] public long Avg { get; set; }

    [JsonPropertyName("min")] public long Min { get; set; }

    [JsonPropertyName("max")] public long Max { get; set; }

    [JsonPropertyName("_id")] public string Id { get; set; }
}