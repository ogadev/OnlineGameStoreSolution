using Microsoft.EntityFrameworkCore;
using OnlineGameStore.Models;

namespace OnlineGameStore.Services;

public class GameService : IGameService
{
	private readonly IMappingGames _mapGamesContext;
	private readonly GameContext _context;

	public GameService(IMappingGames mapGamesContext, GameContext context)
	{
		_mapGamesContext = mapGamesContext;
		_context = context;
	}

	public async Task<IEnumerable<GameDto>> GetGamesAsync()
	{
		var games = await _context.Games.ToArrayAsync();
		var gamesDto = games
			.Select(x => _mapGamesContext.MapGameDto(x));
		return gamesDto;
	}

	public async Task<GameDto> GetGameAsync(int id)
	{
		var game = await _context.Games.SingleOrDefaultAsync(x => x.Id == id);
		if (game is null) return null;
		return _mapGamesContext.MapGameDto(game);
	}

	public async Task PostGameAsync(GameDto gameDto)
	{
		var game = _mapGamesContext.MapGame(gameDto);
		_context.Add(game);
		try
		{
            await _context.SaveChangesAsync();
        }
		catch (Exception e)
		{
			//TODO: catch this exception
		}
	}

	public async Task<GameDto?> UpdateGameAsync(int id, GameDto gameDto)
	{
		var found = _context.Games.AnyAsync(g => g.Id == id);
		if (await found == false) return null;
		
		_context.Entry(_mapGamesContext.MapGame(gameDto)).State = EntityState.Modified;
		try
		{
            await _context.SaveChangesAsync();
        }
		catch (DbUpdateConcurrencyException e)
		{
			throw e;
		}
	
		return gameDto;

	}
}
