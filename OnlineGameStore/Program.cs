using Microsoft.EntityFrameworkCore;
using OnlineGameStore.Models;
using OnlineGameStore.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IMappingGames, MappingGames>();
builder.Services.AddScoped<IGameService, GameService>();
builder.Services.AddDbContext<GameContext>(options =>
    options.UseInMemoryDatabase("Games")
);
//builder.Services.AddMvc(options =>
//{
//    options.Filters.add
//});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
