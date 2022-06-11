using Newtonsoft.Json;

namespace PlantControl.Models;

public class Plant
{
    [JsonProperty("_id")] public string Id { get; set; }

    [JsonProperty("name")] public string Name { get; set; }

    [JsonProperty("createdAt")] public DateTimeOffset CreatedAt { get; set; }

    [JsonProperty("__v")] public long V { get; set; }
}