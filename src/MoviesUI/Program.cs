using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using MoviesAPI;
using MoviesAPI.Services;
using MoviesCore;
using MoviesShared;
using MoviesUI.Data;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<MoviesDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddAutoMapper(typeof(AppAutoMapper).Assembly);
builder.Services.AddRouting(options => options.LowercaseUrls = true);
builder.Services.AddScoped<MoviesRepository>();
builder.Services.AddScoped<GenresRepository>();
builder.Services.AddScoped<ActorsRepository>();
builder.Services.AddScoped<DirectorsRepository>();
builder.Services.AddScoped<PublishersRepository>();

builder.Services.AddScoped<HttpClient>();
builder.Services.AddScoped<HttpMovieService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    
}
else
{
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
