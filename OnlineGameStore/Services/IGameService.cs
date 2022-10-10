using OnlineGameStore.Models;

namespace OnlineGameStore.Services;
public interface IGameService
{
    Task<IEnumerable<GameDto>> GetGamesAsync();
    Task<GameDto> GetGameAsync(int id);
    Task PostGameAsync(GameDto gameDto);
    Task<GameDto> UpdateGameAsync(int id, GameDto gameDto);

}