using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class SubClaseTerrestres : SuperClaseVehiculos
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

        public SubClaseTerrestres(int numLuces, int cantRuedas, string neumaticos, int numVentanas, string capacidad, string carroceria, int capacidadDePasajeros, int numAsientos, string tipoSuspension, string uso) 
        : base("NombreVehiculo", 000000, 00000000, "MarcaVehiculo", "ModeloVehiculo", "ColorVehiculo", "CilindrajeVehiculo", "CombustibleVehiculo", 0.000,0.000)
        {
            this.numLuces = numLuces;
            this.cantRuedas = cantRuedas;
            this.Neumaticos = neumaticos;
            this.numVentanas = numVentanas;
            this.capacidad = capacidad;
            this.carroceria = carroceria;
            this.capacidadDePasajeros = capacidadDePasajeros;
            this.numAsientos = numAsientos;
            this.tipoSuspension = tipoSuspension;
            this.uso = uso;
        }

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
