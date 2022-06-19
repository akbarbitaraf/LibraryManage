using LibraryManage.Contract.IServices;
using LibraryManage.Entities.Context;
using LibraryManage.Entities.DTO.JWT;
using LibraryManage.Repository;
using LoggerService;
using LoggerService.Contrancts;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

namespace LibraryManage.Extentions
{
    public static class ServiceExtentions
    {
        public static void ConfigureCors(this IServiceCollection services) =>

        services.AddCors(options =>
        {
            options.AddPolicy("CorsPolicy", builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
        });
        public static void ConfiqureSqlcontext(this IServiceCollection services, IConfiguration configuration) =>
            services.AddDbContext<LibraryManageContext>(opts =>
            opts.UseSqlServer(configuration.GetConnectionString("sqlConnection"),b=>b.MigrationsAssembly("LibraryManage")));

        public static void ConfigureRepositoryManager(this IServiceCollection services) => services.AddScoped<IRepositoryManager , RepositoryManager>();
        public static void ConfigureLoggertService(this IServiceCollection services) => services.AddScoped<ILoggerManager, ILoggerManager>();
        public static void ConfigureJWT(this IServiceCollection services , IConfiguration configuration) {
            var jwtSettings = configuration.GetSection("JwtSettings").Get<JwtTokenConfig>();
            //var secretKey = Environment.GetEnvironmentVariable("SECRET");
            var secretKey = jwtSettings.secret; 
            services.AddAuthentication(opt =>
            {
                opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = jwtSettings.issuer,
                    ValidAudience = jwtSettings.audience,
                    IssuerSigningKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(secretKey))
                };
            }); 
        }
    }
}
