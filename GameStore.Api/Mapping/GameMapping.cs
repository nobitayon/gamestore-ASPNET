using GameStore.Api.Dtos;

namespace GameStore.Api.Mapping;

public static class GameMapping
{
    public static Game ToEntity(this CreateGameDto Game)
    {
        return new Game()
        {
            Name = Game.Name,
            GenreId = Game.GenreId,
            Price = Game.Price,
            ReleaseDate = Game.ReleaseDate
        };
    }

    public static GameDto ToDto(this Game game)
    {
        return new(
            game.Id, 
            game.Name, 
            game.Genre!.Name, 
            game.Price, 
            game.ReleaseDate
        );
    }
}
