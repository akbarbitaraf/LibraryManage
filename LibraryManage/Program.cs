using LibraryManage.Contract.IServices;
using LibraryManage.Entities.DTO.JWT;
using LibraryManage.Entities.Mapper;
using LibraryManage.Extentions;
using LibraryManage.Services;
using LibraryManage.Services.Interfaces;
using Microsoft.Extensions.Configuration;
using NLog;
using System.IO; 

var builder = WebApplication.CreateBuilder(args);
IConfiguration Configuration = builder.Configuration;
builder.Services.ConfiqureSqlcontext(Configuration);
builder.Services.ConfigureRepositoryManager();
LogManager.LoadConfiguration(string.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));
// Add services to the container.

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IJwtAuthManager, JwtAuthManager>();
builder.Services.AddSingleton(Configuration.GetSection("JwtSettings").Get<JwtTokenConfig>());
builder.Services.ConfigureJWT(Configuration); 
builder.Services.AddAutoMapper(typeof(AutoMapperProfile).Assembly);

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
