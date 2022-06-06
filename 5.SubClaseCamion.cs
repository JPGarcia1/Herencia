using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class SubClaseCamion : SubClaseTerrestres
    {
        private string tipoCarga;
        private string CapacidadCarga;

        public SubClaseCamion(string tipoCarga, string capacidadCarga)
        :base(0, 0, "NeumaticoCamion", 0, "CapacidadCamion", "CarroceriaCamion", 0, 0, "SuspensiónCamion", "UsoCamion")
        {
            this.tipoCarga = tipoCarga;
            this.CapacidadCarga = capacidadCarga;
        }

        public string TipoCarga { get => tipoCarga; set => tipoCarga = value; }
        public string CapacidadCarga1 { get => CapacidadCarga; set => CapacidadCarga = value; }
    }
}
