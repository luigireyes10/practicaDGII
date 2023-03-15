using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IUnitofwork: IDisposable
    {
        ITipoPersonaRepository TipoPersona { get; }

        ITipoAutoMovilRepository TipoAutomovil { get; }

        IPlacaVehiculoRepository PlacaVehiculo { get; }

        IVehiculoRepository Vehiculo { get; }
        int Save();

    }
}
