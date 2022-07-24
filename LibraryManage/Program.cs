using LibraryManage.Contract.IServices;
using LibraryManage.Entities.DTO.JWT;
using LibraryManage.Entities.Mapper;
using LibraryManage.Extentions;
using LibraryManage.Repository;
using LibraryManage.Services;
using LibraryManage.Services.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.OpenApi.Models;
using NLog;
using System.IO; 

var builder = WebApplication.CreateBuilder(args);
IConfiguration Configuration = builder.Configuration;
builder.Services.ConfiqureSqlcontext(Configuration);
builder.Services.ConfigureRepository();
LogManager.LoadConfiguration(Path.Combine(Directory.GetCurrentDirectory(),"nlog.config"));
// Add services to the container.

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "LibraryManage", Version = "v1" });

    var securityScheme = new OpenApiSecurityScheme
    {
        Name = "JWT Authentication",
        Description = "Enter JWT Bearer token **_only_**",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.Http,
        Scheme = "bearer", // must be lower case
        BearerFormat = "JWT",
        Reference = new OpenApiReference
        {
            Id = JwtBearerDefaults.AuthenticationScheme,
            Type = ReferenceType.SecurityScheme
        }
    };
    c.AddSecurityDefinition(securityScheme.Reference.Id, securityScheme);
    c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {securityScheme, new string[] { }}
                });
});

builder.Services.AddControllers();
builder.Services.ConfigureServices();
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
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

//app.MapControllers();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});
app.Run();
