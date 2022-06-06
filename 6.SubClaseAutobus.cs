using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class SubClaseAutobus : SubClaseTerrestres
    {
        private string rutas;

        private double valorPasaje;

        public SubClaseAutobus(string rutas, double valorPasaje)
        :base(0, 0, "NeumaticoAutobus", 0, "CapacidadAutobus", "CarroceriaAutobus", 0, 0, "SuspensiónAutobus", "UsoAutobus")
        {
            this.rutas = rutas;
            this.valorPasaje = valorPasaje;
        }

        public string Rutas { get => rutas; set => rutas = value; }
        public double ValorPasaje { get => valorPasaje; set => valorPasaje = value; }
    }
}
