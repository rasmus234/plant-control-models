using System;
using System.Text.Json.Serialization;

namespace PlantControl.Models;

public class Plant
{
    public string Name { get; set; }
    [JsonPropertyName("_id")]
    public string Id { get; set; }
    public DateTime CreatedAt { get; set; }
}