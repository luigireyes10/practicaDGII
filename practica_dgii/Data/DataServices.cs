using Core.Interfaces;
using Data.Context;
using Data.Repositorio;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Data
{
    public static class DataServices
    {
        public static IServiceCollection adddataservices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(option => option.UseSqlServer(configuration.GetConnectionString("connexiondb"),
                b => b.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName)));


            services.AddTransient<IUnitofwork, UnitOfWork>();
            services.AddScoped(typeof(IgenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<ITipoPersonaRepository, TipoPersonaRepository>();
            services.AddScoped<ITipoAutoMovilRepository, TipoAutomovilRepository>();
            services.AddScoped<IPlacaVehiculoRepository, PlacaVehiculoRepository>();
            services.AddScoped<IVehiculoRepository, VehiculoRepository>();
            return services;
        }

    }
}