using Core.Interfaces;
using Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositorio
{
    public class UnitOfWork: IUnitofwork, IDisposable
    {

        private readonly AppDbContext _context;

       

        public ITipoPersonaRepository PersonaRepository { get; private set; }

        public IPlacaVehiculoRepository PlacaVehiculo => throw new NotImplementedException();

        public IVehiculoRepository Vehiculo => throw new NotImplementedException();

        ITipoPersonaRepository IUnitofwork.TipoPersona => throw new NotImplementedException();

        ITipoAutoMovilRepository IUnitofwork.TipoAutomovil => throw new NotImplementedException();

        public void Dispose()
        {
            _context.Dispose();
        }

        public int Save()
        {
            
            return _context.SaveChanges();
        }

        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }

        int IUnitofwork.Save()
        {
            throw new NotImplementedException();
        }
    }
}
