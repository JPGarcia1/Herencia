using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Camion
    {
        private string tipoCarga;
        private string CapacidadCarga;

        public string TipoCarga { get => tipoCarga; set => tipoCarga = value; }
        public string CapacidadCarga1 { get => CapacidadCarga; set => CapacidadCarga = value; }
    }
}
