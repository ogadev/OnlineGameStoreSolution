using AutoMapper;

namespace OnlineGameStore.Models;

public class MappingGames : IMappingGames
{
	public Game MapGame(GameDto game)
	{
		return new Game
		{
			Id = game.Id,
			Title = game.Title,
			Publisher = game.Publisher,
			ReleaseDate = game.ReleaseDate,
			Description = game.Description,
			RatingLetter = game.ESRB.Letter,
			RatingDescription = game.ESRB.Description,
			MinOs = game.Minimum.OS,
			MinProcessor = game.Minimum.Processor,
			MinMemory = game.Minimum.Memory,
			MinGraphics = game.Minimum.Graphics,
			MinStorage = game.Minimum.Storage,
			RecOs = game.Recommended.OS,
			RecProcessor = game.Recommended.Processor,
			RecGraphics = game.Recommended.Graphics,
			RecMemory = game.Recommended.Memory,
			RecStorage = game.Recommended.Storage,
			Price = game.Price,
			CategoryId = game.CategoryId,
			Category = game.Category
		};
	}

	public GameDto MapGameDto(Game game)
	{
		return new GameDto
		{
			Id = game.Id,
			Title = game.Title,
			Publisher = game.Publisher,
			ReleaseDate = game.ReleaseDate,
			Description = game.Description,
			ESRB = new Rating { Description = game.RatingDescription, Letter = game.RatingLetter },
			Minimum = new SystemRequirements { OS = game.MinOs, Processor = game.MinProcessor, Memory = game.MinMemory, Graphics = game.MinGraphics, Storage = game.MinStorage },
			Recommended = new SystemRequirements { OS = game.RecOs, Processor = game.RecProcessor, Memory = game.RecMemory, Graphics = game.RecGraphics, Storage = game.RecStorage },
			Price = game.Price,
			CategoryId = game.CategoryId,
			Category = game.Category
		};

	}
}
