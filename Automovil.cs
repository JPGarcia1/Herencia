using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Automovil : Terrestres
    {
        private string capacidadMaletero;

        public string CapacidadMaletero { get => capacidadMaletero; set => capacidadMaletero = value; }
    }
}
