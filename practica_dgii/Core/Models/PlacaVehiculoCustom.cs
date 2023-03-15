using Core.Models.commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class PlacaVehiculoCustom : BaseDomain
    {
        public string TipoPlaca { get; set; }
        public string NúmeroPlaca { get; set; }

        public virtual Cliente  DatosCliente { get; set; }
        public DateTime FechaVenta { get; set; }


      


      

    }
}
