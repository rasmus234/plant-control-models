using Newtonsoft.Json;

namespace PlantControl.Models;

public class Logger
{
    [JsonProperty("_id")] public string Id { get; set; }

    [JsonProperty("name")] public string Name { get; set; }

    [JsonProperty("isPaired")] public bool IsPaired { get; set; }

    [JsonProperty("__v")] public long V { get; set; }
}