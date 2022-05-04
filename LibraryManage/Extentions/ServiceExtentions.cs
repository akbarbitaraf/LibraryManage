using LibraryManage.Contract.IServices;
using LibraryManage.Entities.Context;
using LibraryManage.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
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
    }
}
