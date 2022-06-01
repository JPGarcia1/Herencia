using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Terrestres
    {
        private string numLuces;
        private string nombreVehiculo;
        private int cantRueadas;
        private string Neumaticos;
        private int numVentanas;
        private string capacidad;
        private string carroceria;
        private int capacidadDePasajeros;
        private int numAsientos;
        private string tipoSuspension;
        private string uso;

        public string NumLuces { get => numLuces; set => numLuces = value; }
        public string NombreVehiculo { get => nombreVehiculo; set => nombreVehiculo = value; }
        public int CantRueadas { get => cantRueadas; set => cantRueadas = value; }
        public string Neumaticos1 { get => Neumaticos; set => Neumaticos = value; }
        public int NumVentanas { get => numVentanas; set => numVentanas = value; }
        public string Capacidad { get => capacidad; set => capacidad = value; }
        public string Carroceria { get => carroceria; set => carroceria = value; }
        public int CapacidadDePasajeros { get => capacidadDePasajeros; set => capacidadDePasajeros = value; }
        public int NumAsientos { get => numAsientos; set => numAsientos = value; }
        public string TipoSuspension { get => tipoSuspension; set => tipoSuspension = value; }
        public string Uso { get => uso; set => uso = value; }
    }
}
