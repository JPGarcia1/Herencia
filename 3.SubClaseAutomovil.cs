using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class SubClaseAutomovil : SubClaseTerrestres
    {
        private string capacidadMaletero;

        public SubClaseAutomovil(string capacidadMaletero)
        :base(0, 0, "NeumaticoAutomovil", 0, "CapacidadAutomovil", "CarroceriaAutomovil", 0, 0, "SuspensiónAutomovil", "UsoAutomovil")
        {
            this.capacidadMaletero = capacidadMaletero;
        }

        public string CapacidadMaletero { get => capacidadMaletero; set => capacidadMaletero = value; }
    }
}
