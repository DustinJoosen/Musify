using Microsoft.CodeAnalysis.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Musify.API.Data;
using Musify.API.Middleware;
using Musify.API.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DbConn"));
});

builder.Services.AddScoped<IArtistService, ArtistService>();
builder.Services.AddScoped<IAlbumService, AlbumService>();
builder.Services.AddScoped<ISongService, SongService>();
builder.Services.AddScoped<IPlaylistService, PlaylistService>();

builder.Services.AddScoped<IApiKeyService, ApiKeyService>();
builder.Services.AddScoped<IAuthService, AuthService>();

builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(config =>
{
    config.SwaggerDoc("v1", new OpenApiInfo { Title = "Musify API", Version = "v1", });

    config.AddSecurityDefinition("ApiKey", new OpenApiSecurityScheme
    {
        Description = "ApiKey must appear in header",
        Type = SecuritySchemeType.ApiKey,
        Name = "ApiKey",
        In = ParameterLocation.Header,
        Scheme = "ApiKeyScheme"
    });

    var key = new OpenApiSecurityScheme()
    {
        Reference = new OpenApiReference
        {
            Type = ReferenceType.SecurityScheme,
            Id = "ApiKey"
        },
        In = ParameterLocation.Header
    };

    config.AddSecurityRequirement(new OpenApiSecurityRequirement { { key, new string[] { } } });
});


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
