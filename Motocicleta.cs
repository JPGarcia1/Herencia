using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Motocicleta
    {
        private string chasis;
        private string tipoMotor;

        public string Chasis { get => chasis; set => chasis = value; }
        public string TipoMotor { get => tipoMotor; set => tipoMotor = value; }
    }
}
