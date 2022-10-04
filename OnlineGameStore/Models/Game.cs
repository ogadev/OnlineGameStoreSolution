using System.Text.Json.Serialization;

namespace OnlineGameStore.Models;

public class Game
{
    public int Id { get; set; } 
    public string Title { get; set; } = string.Empty;
    public string Publisher { get; set; } = string.Empty;
    public DateTime ReleaseDate { get; set; }
    public string Description { get; set; } = string.Empty;
    public Rating ESRB { get; set; }
    public SystemRequirements Minimum { get; set; } 
    public SystemRequirements Recommended { get; set; }
    public decimal Price { get; set; }
    public int CategoryId { get; set; }
    [JsonIgnore]
    public virtual Category? Category { get; set; }
}
