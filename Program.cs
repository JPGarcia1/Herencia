using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Automovil automovil;
            automovil = new Automovil();

            automovil.Matricula1 = 5127369;
            automovil.Marca = "Chevrolet";
            automovil.Modelo = "Joy Sedan";
            automovil.Cilindraje = "1,4 Litros";
            automovil.Combustible = "Gasolina";
            automovil.Ancho1 = 1.964;
            automovil.Largo1 = 4.275;
            automovil.CantRuedas = 4;
            automovil.Neumaticos1 = "185/70 R14";
            automovil.Capacidad = "650 kilómetros por tanque completo de gasolina";
            automovil.Carroceria = "sedan";
            automovil.NumAsientos = 4;
            automovil.Uso = "particular";
            automovil.CapacidadMaletero = "500 Kg.";

            Console.WriteLine("~~~~~~Automovil~~~~~~");
            Console.WriteLine("~~~~~Propiedades~~~~~");
            Console.WriteLine("Matricula: "+automovil.Matricula1);
            Console.WriteLine("Marca: " + automovil.Marca);
            Console.WriteLine("Modelo: " + automovil.Marca);
            Console.WriteLine("Capacidad de cilindraje de: "+ automovil.Cilindraje);
            Console.WriteLine("Combustible utilizado: "+automovil.Combustible);
            Console.WriteLine("El ancho es de "+automovil.Ancho1+" metros.");
            Console.WriteLine("El largo es de "+automovil.Largo1+" metros.");
            Console.WriteLine("Cuenta con "+automovil.CantRuedas+" ruedas.");
            Console.WriteLine("Neumaticos tipo: "+automovil.Neumaticos1);
            Console.WriteLine("Capacidad de viajar "+ automovil.Capacidad);
            Console.WriteLine("Carroceria tipo "+automovil.Carroceria);
            Console.WriteLine("Tiene un total de "+automovil.NumAsientos+" asientos");
            Console.WriteLine("Es de uso "+automovil.Uso);
            Console.WriteLine("Maletero con capacidad de "+automovil.CapacidadMaletero);
        }
    }
}
