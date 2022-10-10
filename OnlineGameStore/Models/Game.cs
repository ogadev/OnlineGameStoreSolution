using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace OnlineGameStore.Models;

public class Game
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Publisher { get; set; } = string.Empty;
    public DateTime ReleaseDate { get; set; }
    public string Description { get; set; } = string.Empty;
    public char RatingLetter { get; set; }
    public string RatingDescription { get; set; } = string.Empty;
    public string MinOs { get; set; } = string.Empty;
    public string MinProcessor { get; set; }= string.Empty;
    public string MinMemory { get; set; }   = string.Empty;
    public string MinGraphics { get; set; } = string.Empty;
    public string MinStorage { get; set; } = string.Empty;
    public string RecOs { get; set; } = string.Empty;
    public string RecProcessor { get; set; } = string.Empty;
    public string RecMemory { get; set; } = string.Empty;
    public string RecGraphics { get; set; } = string.Empty;
    public string RecStorage { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int CategoryId { get; set; }
    [JsonIgnore]
    public virtual Category? Category { get; set; }
}
