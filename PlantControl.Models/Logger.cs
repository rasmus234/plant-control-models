using System;
using System.Text.Json.Serialization;

namespace PlantControl.Models;

public class Logger
{
    [JsonPropertyName("_id")]
    public string Id { get; set; }
    public string Name { get; set; }
    public DateTime? LoginTime { get; set; }
    public bool IsPaired { get; set; } = false;
}