using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class SubClaseMotocicleta : SubClaseTerrestres
    {
        private string chasis;
        private string tipoMotor;

        public SubClaseMotocicleta(string chasis, string tipoMotor)
        :base(0,0,"NeumaticoMotocicleta",0, "CapacidadMotocicleta","CarroceriaMotocicleta",0,0, "SuspensiónMotocicleta","UsoMotocicleta")
        {
            this.chasis = chasis;
            this.tipoMotor = tipoMotor;
        }

        public string Chasis { get => chasis; set => chasis = value; }
        public string TipoMotor { get => tipoMotor; set => tipoMotor = value; }
    }
}
