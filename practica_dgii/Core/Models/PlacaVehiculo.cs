using Core.Models.commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class PlacaVehiculo: BaseDomain
    {
        public string NumeroPlaca { get; set; }

        public virtual Cliente DatosCliente { get; set; }
       

        public string TipoPlaca { get; set; }

       
        public virtual Vehiculo idVehiculo { get; set; }

        public int tipoPersonaId { get; set; }

        public int tipoAutomovilId { get; set; }

        public virtual TipoPersona tipoPersona { get; set; }

        public virtual TipoAutomovil tipoAutomovi { get; set; }

    }
}
