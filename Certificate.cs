using Newtonsoft.Json;

namespace PlantControl.Models;

public class Certificate
{
    [JsonProperty("plant")] public Plant Plant { get; set; }

    [JsonProperty("temperature")] public Data Temperature { get; set; }

    [JsonProperty("humidity")] public Data Humidity { get; set; }

    [JsonProperty("moisture")] public Data Moisture { get; set; }

    [JsonProperty("_id")] public string Id { get; set; }

    [JsonProperty("createdAt")] public DateTimeOffset CreatedAt { get; set; }

    [JsonProperty("__v")] public long V { get; set; }
}

public class Data
{
    [JsonProperty("avg")] public long Avg { get; set; }

    [JsonProperty("min")] public long Min { get; set; }

    [JsonProperty("max")] public long Max { get; set; }

    [JsonProperty("_id")] public string Id { get; set; }
}