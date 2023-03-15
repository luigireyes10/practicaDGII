using Core.Interfaces;
using Core.Models;
using Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositorio
{
  
    public class PlacaVehiculoRepository : GenericRepository<PlacaVehiculo>, IPlacaVehiculoRepository
    {
        public PlacaVehiculoRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
