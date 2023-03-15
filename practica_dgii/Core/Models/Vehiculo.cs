using Core.Models.commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Vehiculo : BaseDomain
    {
        public string idVehiculo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public string Estilo { get; set; }

        public string Anio { get; set; }

        public string tipoVehiculo { get; set; }

        public string Chasis { get; set; }




    }
}
