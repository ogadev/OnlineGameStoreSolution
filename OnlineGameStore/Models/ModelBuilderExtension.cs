using Microsoft.EntityFrameworkCore;

namespace OnlineGameStore.Models;

public static class ModelBuilderExtension
{
  
    public static void Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "Shooters (FPS and TPS)" },
            new Category { Id = 2, Name = "Action-adventure" },
            new Category { Id = 3, Name = "Multiplayer online battle arena (MOBA)" },
            new Category { Id = 4, Name = "Platformer" },
            new Category { Id = 5, Name = "Survival and horror" },
            new Category { Id = 6, Name = "Simulation and sports" },
            new Category { Id = 7, Name = "Real-time stradegy (RTS)" },
            new Category { Id = 8, Name = "Puzzlers and party games" },
            new Category { Id = 9, Name = "Role-playing (RPG, ARPG, and More)" },
            new Category { Id = 10, Name = "Sandbox" });

        modelBuilder.Entity<Game>().HasData(
            new Game
            {
                Id = 1,
                Title = "Modern Warfare II",
                CategoryId = 1,
                Description = "Pretty much world war 3",
                RatingDescription = "Mature", RatingLetter = 'M',
                ReleaseDate = new DateTime(2022, 10, 28),
                Price = 69.99M,
                Publisher = "Activision",
                MinGraphics = "RTX 3090", MinMemory = "16GB", MinOs = "Windows", MinProcessor = "i9", MinStorage = "60GB",
                RecGraphics = "RTX 3090", RecMemory = "16GB", RecOs = "Windows", RecProcessor = "i9", RecStorage = "60GB" 
            },
             new Game
             {
                 Id = 2,
                 Title = "Spiderman",
                 CategoryId = 2,
                 Description = "Swing around New York City as Spiderman",
                 RatingDescription = "Teen", RatingLetter = 'T',
                 ReleaseDate = new DateTime(2022, 7, 22),
                 Price = 69.99M,
                 Publisher = "Insomniac Games",
                 MinGraphics = "RTX 3060", MinMemory = "16GB", MinOs = "Windows", MinProcessor = "i5", MinStorage = "55GB" ,
                 RecGraphics = "RTX 3080", RecMemory = "16GB", RecOs = "Windows", RecProcessor = "I9", RecStorage = "55GB" 
             },
              new Game
              {
                  Id = 3,
                  Title = "FIFA 23",
                  CategoryId = 6,
                  Description = "Play like Messi!",
                  RatingDescription = "Everyone", RatingLetter = 'E',
                  ReleaseDate = new DateTime(2022, 10, 1),
                  Price = 59.99M,
                  Publisher = "Elecrtronic Arts",
                  MinGraphics = "RX 5600 XT", MinMemory = "8GB", MinOs = "Windows", MinProcessor = "i5", MinStorage = "100GB",
                  RecGraphics = "RX 5600 XT", RecMemory = "12GB", RecOs = "Windows", RecProcessor = "I9", RecStorage = "100GB" 
              },
               new Game
               {
                   Id = 4,
                   Title = "NBA 2K23",
                   CategoryId = 6,
                   Description = "Take on NBA or WNBA teams in PLAY NOW and feel true-to-life gameplay.",
                   RatingDescription = "Everyone", RatingLetter = 'E',
                   ReleaseDate = new DateTime(2022, 9, 8),
                   Price = 59.99M,
                   Publisher = "2K",
                   MinGraphics = "RX 5600 XT", MinMemory = "8GB", MinOs = "Windows", MinProcessor = "i3", MinStorage = "110GB",
                   RecGraphics = "RX 5600 XT", RecMemory = "12GB", RecOs = "Windows", RecProcessor = "i5", RecStorage = "110GB" 
               },
               new Game
               {
                   Id = 5,
                   Title = "Halo Infinite",
                   CategoryId = 1,
                   Description = "The legendary Halo series returns with the most expansive Master Chief campaig",
                   RatingDescription = "Teen", RatingLetter = 'T',
                   ReleaseDate = new DateTime(2021, 11, 9),
                   Price = 49.99M,
                   Publisher = "Xbox Game Studios",
                   MinGraphics = "RX 570", MinMemory = "8GB", MinOs = "Windows", MinProcessor = "Ryzen 5 1600", MinStorage = "50GB",
                   RecGraphics = "RX 5600 XT", RecMemory = "16GB", RecOs = "Windows", RecProcessor = "Ryzen 7 3700X", RecStorage = "50GB"
               });
    }
   
}
