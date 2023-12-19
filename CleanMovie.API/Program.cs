using CleanMovie.Application.Services;
using CleanMovie.Application.Repositories;
using CleanMovie.Infrastructure.Repositories;
using CleanMovie.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add Database Service
builder.Services.AddDbContext<MovieDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("MovieConnection"),
    b => b.MigrationsAssembly("CleanMovie.API")));

builder.Services.AddScoped<IMovieService, MovieService>();
builder.Services.AddScoped<IMovieRepository, MovieRepository>();

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
