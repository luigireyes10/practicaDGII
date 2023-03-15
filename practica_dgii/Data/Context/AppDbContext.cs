using Core.Models;
using Core.Models.commons;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public AppDbContext(DbSet<PlacaVehiculo> placaVehiculos, DbSet<TipoAutomovil> tipoAutomoviles, DbSet<TipoPersona> tipoPersonas, DbSet<Vehiculo> vehiculos)
        {
            PlacaVehiculos = placaVehiculos;
            TipoAutomoviles = tipoAutomoviles;
            TipoPersonas = tipoPersonas;
            Vehiculos = vehiculos;
        }

        public DbSet<PlacaVehiculo>PlacaVehiculos { get; set; }
        public DbSet<TipoAutomovil> TipoAutomoviles { get; set; }

        public DbSet<TipoPersona> TipoPersonas { get; set; }

        public DbSet<Vehiculo> Vehiculos { get; set; }


        public override Task<int> SaveChangesAsync( CancellationToken cancellationToken = default)
        {

             foreach (var item in ChangeTracker.Entries<BaseDomain>())
            {
                switch (item.State)
                {
                    case EntityState.Added:
                        item.Entity.activo = true;
                        item.Entity.CreatedBy = "System";
                        item.Entity.CreatedDate = DateTime.Now;
                        item.Entity.DeletedRecord = false;
                        break;
                    //case EntityState.Modified:
                    //    item.Entity.activo = true; break;
                    case EntityState.Modified:
                        item.Entity.LastModifiedDate = DateTime.Now;
                        item.Entity.LastModifiedBy = "System";
                        break;
                    default:
                        break;
                }

            }

            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());  
        }



    }
}
