using System.Text.Json.Serialization;


namespace PlantControl.Models
{
    public class Warning
    {
        [JsonPropertyName("title")] public string Title { get; set; }
        [JsonPropertyName("description")] public string Description { get; set; }
        [JsonPropertyName("createdAt")] public DateTime CreatedAt { get; set; }
    }
}
