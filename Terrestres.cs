using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Terrestres : Vehiculos
    {
        private int numLuces;
        private int cantRuedas;
        private string Neumaticos;
        private int numVentanas;
        private string capacidad;
        private string carroceria;
        private int capacidadDePasajeros;
        private int numAsientos;
        private string tipoSuspension;
        private string uso;

        public int NumLuces { get => numLuces; set => numLuces = value; }
        public int CantRuedas { get => cantRuedas; set => cantRuedas = value; }
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
