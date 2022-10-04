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
                ESRB = { Description = "Mature", Letter = 'M' },
                ReleaseDate = new DateTime(2022, 10, 28),
                Price = 69.99M,
                Publisher = "Activision",
                Minimum = { Graphics = "RTX 3090", Memory = "16GB", OS = "Windows", Processor = "i9", Storage = "60GB" },
                Recommended = { Graphics = "RTX 3090", Memory = "16GB", OS = "Windows", Processor = "i9", Storage = "60GB" }
            },
             new Game
             {
                 Id = 2,
                 Title = "Spiderman",
                 CategoryId = 2,
                 Description = "Swing around New York City as Spiderman",
                 ESRB = { Description = "Teen", Letter = 'T' },
                 ReleaseDate = new DateTime(2022, 7, 22),
                 Price = 69.99M,
                 Publisher = "Insomniac Games",
                 Minimum = { Graphics = "RTX 3060", Memory = "16GB", OS = "Windows", Processor = "i5", Storage = "55GB" },
                 Recommended = { Graphics = "RTX 3080", Memory = "16GB", OS = "Windows", Processor = "I9", Storage = "55GB" }
             },
              new Game
              {
                  Id = 3,
                  Title = "FIFA 23",
                  CategoryId = 6,
                  Description = "Play like Messi!",
                  ESRB = { Description = "Everyone", Letter = 'E' },
                  ReleaseDate = new DateTime(2022, 10, 1),
                  Price = 59.99M,
                  Publisher = "Elecrtronic Arts",
                  Minimum = { Graphics = "RX 5600 XT", Memory = "8GB", OS = "Windows", Processor = "i5", Storage = "100GB" },
                  Recommended = { Graphics = "RX 5600 XT", Memory = "12GB", OS = "Windows", Processor = "I9", Storage = "100GB" }
              },
               new Game
               {
                   Id = 4,
                   Title = "NBA 2K23",
                   CategoryId = 6,
                   Description = "Take on NBA or WNBA teams in PLAY NOW and feel true-to-life gameplay.",
                   ESRB = { Description = "Everyone", Letter = 'E' },
                   ReleaseDate = new DateTime(2022, 9, 8),
                   Price = 59.99M,
                   Publisher = "2K",
                   Minimum = { Graphics = "RX 5600 XT", Memory = "8GB", OS = "Windows", Processor = "i3", Storage = "110GB" },
                   Recommended = { Graphics = "RX 5600 XT", Memory = "12GB", OS = "Windows", Processor = "i5", Storage = "110GB" }
               },
               new Game
               {
                   Id = 5,
                   Title = "Halo Infinite",
                   CategoryId = 1,
                   Description = "The legendary Halo series returns with the most expansive Master Chief campaig",
                   ESRB = { Description = "Teen", Letter = 'T' },
                   ReleaseDate = new DateTime(2021, 11, 9),
                   Price = 49.99M,
                   Publisher = "Xbox Game Studios",
                   Minimum = { Graphics = "RX 570", Memory = "8GB", OS = "Windows", Processor = "Ryzen 5 1600", Storage = "50GB" },
                   Recommended = { Graphics = "RX 5600 XT", Memory = "16GB", OS = "Windows", Processor = "Ryzen 7 3700X", Storage = "50GB" }
               });
    }
   
}
