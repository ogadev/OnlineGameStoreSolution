namespace OnlineGameStore.Models;

public interface IMappingGames
{
    Game MapGame(GameDto game);
    GameDto MapGameDto(Game game);
}