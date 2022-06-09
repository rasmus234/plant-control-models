using System;
using System.Text.Json.Serialization;

namespace PlantControl.Models;

public class Pairing
{
    public string Name { get; set; }
    public DateTime CreatedAt { get; set; }
    public Plant Plant { get; set; }
    [JsonPropertyName("_id")]
    public string Id { get; set; }
    public Logger Logger { get; set; }
}