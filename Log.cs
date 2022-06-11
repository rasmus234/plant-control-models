using Newtonsoft.Json;

namespace PlantControl.Models;

public class Log
{
    [JsonProperty("temperature")] public long Temperature { get; set; }

    [JsonProperty("humidity")] public long Humidity { get; set; }

    [JsonProperty("moisture")] public long Moisture { get; set; }

    [JsonProperty("pairing")] public string Pairing { get; set; }

    [JsonProperty("_id")] public string Id { get; set; }

    [JsonProperty("time")] public DateTimeOffset Time { get; set; }

    [JsonProperty("__v")] public long V { get; set; }
}