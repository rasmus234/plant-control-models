using System;
using System.Text.Json.Serialization;

namespace PlantControl.Models;

public class Certificate
{
    [JsonPropertyName("_id")]
    public string Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public Plant Plant { get; set; }
}