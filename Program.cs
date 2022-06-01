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
            Console.WriteLine("Modelo: " + automovil.Modelo);
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


            Motocicleta motocicleta;
            motocicleta = new Motocicleta();

            motocicleta.Nombre = "Pulsar 180 Fi Neon.";
            motocicleta.Matricula1 = 152362;
            motocicleta.Marca = "Pulsar.";
            motocicleta.Modelo = "2022.";
            motocicleta.Cilindraje = "178.6 centimetros cubicos.";
            motocicleta.Combustible = "Gasolina.";
            motocicleta.Ancho1 = 0.765;
            motocicleta.Largo1 = 2.035;
            motocicleta.TipoSuspension = "Suspensión delantera: Telescópico, con casquillo anti fricción.\n" +
                                         "Suspensión trasera: 2 amortiguadores nitrox.";
            motocicleta.CantRuedas = 2;
            motocicleta.Neumaticos1 = "90/90-17 49P Tubeless.";
            motocicleta.Capacidad = "168km por galón.";
            motocicleta.NumAsientos = 1;
            motocicleta.Uso = "particular.";

            motocicleta.Chasis = "Acero.";
            motocicleta.TipoMotor = "4 Tiempos, Monocilíndrico, SOHC, DTSi, 4 Válvulas.";

            Console.WriteLine("~~~~~Motocicleta~~~~~");
            Console.WriteLine("~~~~~Propiedades~~~~~");
            Console.WriteLine("Nombre: "+motocicleta.Nombre);
            Console.WriteLine("Matricula: " + motocicleta.Matricula1 + ".");
            Console.WriteLine("Marca: " + motocicleta.Marca);
            Console.WriteLine("Modelo: " + motocicleta.Modelo);
            Console.WriteLine("Capacidad de cilindraje de: " + motocicleta.Cilindraje);
            Console.WriteLine("Combustible: " + motocicleta.Combustible);
            Console.WriteLine("Ancho: " + motocicleta.Ancho1 + " metros.");
            Console.WriteLine("Largo: " + motocicleta.Largo1 + " metros.");
            Console.WriteLine(motocicleta.TipoSuspension);
            Console.WriteLine("Cuenta con " + motocicleta.CantRuedas + " ruedas.");
            Console.WriteLine("Neumaticos tipo: " + motocicleta.Neumaticos1);
            Console.WriteLine("Capacidad de viajar " + motocicleta.Capacidad);
            Console.WriteLine("Cuenta con " + motocicleta.NumAsientos + " asiento.");
            Console.WriteLine("Es de uso " + motocicleta.Uso);

            Console.WriteLine("Chasis de " + motocicleta.Chasis);
            Console.WriteLine("Motor de "+motocicleta.TipoMotor);


            Camion camion;
            camion = new Camion();

            camion.Nombre = "Camión NPR Euro IV.";
            camion.Matricula1 = 371277;
            camion.Marca = "Chevrolet.";
            camion.Modelo = "NPR.";
            camion.Cilindraje = "5.2 Litros.";
            camion.Combustible = "Diesel.";
            camion.Ancho1 = 2.040;
            camion.Largo1 = 5.985;
            camion.CantRuedas = 6;
            camion.Neumaticos1 = "215 / 75 R 17,5";
            camion.Capacidad = "14.5 kilómetros por galón.";
            camion.NumAsientos = 2;
            camion.Uso = "Privado o público.";

            camion.TipoCarga = "Alimentos.";
            camion.CapacidadCarga1 = "4.782 Kg.";

            Console.WriteLine("~~~~~~~~Camión~~~~~~~");
            Console.WriteLine("~~~~~Propiedades~~~~~");
            Console.WriteLine("Nombre: " + camion.Nombre);
            Console.WriteLine("Matricula: " + camion.Matricula1 + ".");
            Console.WriteLine("Marca: " + camion.Marca);
            Console.WriteLine("Modelo: " + camion.Modelo);
            Console.WriteLine("Capacidad de cilindraje de: " + camion.Cilindraje);
            Console.WriteLine("Combustible: " + camion.Combustible);
            Console.WriteLine("Ancho: " + camion.Ancho1 + " metros.");
            Console.WriteLine("Largo: " + camion.Largo1 + " metros.");
            Console.WriteLine("Cuenta con " + camion.CantRuedas + " ruedas.");
            Console.WriteLine("Neumaticos tipo: " + camion.Neumaticos1);
            Console.WriteLine("Capacidad de viajar " + camion.Capacidad);
            Console.WriteLine("Cuenta con " + camion.NumAsientos + " asientos.");
            Console.WriteLine("Es de uso " + camion.Uso);

            Console.WriteLine("Carga: " + camion.TipoCarga);
            Console.WriteLine("Motor de carga: " + camion.CapacidadCarga1);
        }
    }
}
