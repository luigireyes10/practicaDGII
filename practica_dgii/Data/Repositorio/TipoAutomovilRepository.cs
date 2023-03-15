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
    public class TipoAutomovilRepository : GenericRepository<TipoAutomovil>, ITipoAutoMovilRepository
    {
        public TipoAutomovilRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
