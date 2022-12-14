using Microsoft.EntityFrameworkCore;
using MoviesAPI;
using MoviesCore;
using MoviesShared;
using System.Reflection;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options => 
{
    options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Version = "v1",
        Title= "Movies Website Project API",
        Description = "Educational project"
    });
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
   options.IncludeXmlComments(xmlPath);
});

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<MoviesDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddAutoMapper(typeof(AppAutoMapper).Assembly);
builder.Services.AddRouting(options => options.LowercaseUrls = true);
builder.Services.AddScoped<MoviesRepository>();
builder.Services.AddScoped<GenresRepository>();
builder.Services.AddScoped<ActorsRepository>();
builder.Services.AddScoped<DirectorsRepository>();
builder.Services.AddScoped<PublishersRepository>();
//builder.Services.AddScoped<UsersRepository>();

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
