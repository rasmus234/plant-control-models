using System.Text.Json.Serialization;

namespace PlantControl.Models;

public class Logger
{
    [JsonPropertyName("_id")] public string Id { get; set; }

    [JsonPropertyName("name")] public string Name { get; set; }

    [JsonPropertyName("isPaired")] public bool IsPaired { get; set; }

    [JsonPropertyName("__v")] public long V { get; set; }
}