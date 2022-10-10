using System.Text.Json.Serialization;

namespace OnlineGameStore.Models;

public class GameDto
{
    public int Id { get; set; } 
    public string Title { get; set; } = string.Empty;
    public string Publisher { get; set; } = string.Empty;
    public DateTime ReleaseDate { get; set; }
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int CategoryId { get; set; }
    public Rating ESRB { get; set; }
    public SystemRequirements Minimum { get; set; } 
    public SystemRequirements Recommended { get; set; }
   
    [JsonIgnore]
    public Category? Category { get; set; }
}
