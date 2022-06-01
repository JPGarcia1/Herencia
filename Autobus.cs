using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Autobus : Terrestres
    {
        private string rutas;

        private double valorPasaje;

        public string Rutas { get => rutas; set => rutas = value; }
        public double ValorPasaje { get => valorPasaje; set => valorPasaje = value; }
    }
}
