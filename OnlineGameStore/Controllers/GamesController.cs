using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineGameStore.Models;
using OnlineGameStore.Services;

namespace OnlineGameStore.Controllers;

[Route("[controller]")]
[ApiController]
public class GamesController : ControllerBase
{
    private readonly GameContext _context;
	private readonly IGameService _gameService;

	public GamesController(GameContext context, IGameService gameService)
	{
		_context = context;
		_context.Database.EnsureCreated();
		_gameService = gameService;
	}

	[HttpGet]
	public async Task<ActionResult> GetGames()
	{
		var games = await _gameService.GetGamesAsync();
		return Ok(games);
	}

	[HttpGet("{id}")]
	public async Task<ActionResult> GetGame(int id)
	{
		var game = await _gameService.GetGameAsync(id);
		if (game is null) return NotFound();
		return Ok(game);
    }

	[HttpPost]
	public async Task<ActionResult> PostGame(GameDto game)
	{
		await _gameService.PostGameAsync(game);

		return CreatedAtAction(
			"GetGame",
			new {id = game.Id},
			game);
	}

	[HttpPut("{id}")]
	public async Task<ActionResult> UpdateGame(int id, [FromBody]GameDto game)
	{
		if (id != game.Id) return BadRequest();
		var gameFormatted = await _gameService.UpdateGameAsync(id, game);
		if (gameFormatted is null) return NotFound();
		return NoContent();

	}

	[HttpGet("/Category{id}")]
	public async Task<ActionResult> GetGamesFromCategory(int id)
	{
		var category = await _context.Categories.SingleOrDefaultAsync(x => x.Id == id);
		if(category is null) return NotFound();
		
		var listOfGames = await _context.Games.Where(x => x.CategoryId == id).ToArrayAsync();

		category.Games = listOfGames;

		return Ok(category);
	}
	





}
