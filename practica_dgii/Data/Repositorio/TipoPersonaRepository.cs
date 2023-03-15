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
    public class TipoPersonaRepository : GenericRepository<TipoPersona>, ITipoPersonaRepository
    {
        public TipoPersonaRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
