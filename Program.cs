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
            SubClaseAutomovil automovil;
            automovil = new SubClaseAutomovil("500 Kg.");

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

            Console.WriteLine("Maletero con capacidad de "+automovil.CapacidadMaletero+"\n");


            SubClaseMotocicleta motocicleta;
            motocicleta = new SubClaseMotocicleta("Acero.", "4 Tiempos, Monocilíndrico, SOHC, DTSi, 4 Válvulas.");

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

            Console.WriteLine("\n~~~~~Motocicleta~~~~~");
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
            Console.WriteLine("Motor de "+motocicleta.TipoMotor+"\n");


            SubClaseCamion camion;
            camion = new SubClaseCamion("Alimentos.", "4.782 Kg.");

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

            Console.WriteLine("\n~~~~~~~~Camión~~~~~~~");
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
            Console.WriteLine("Motor de carga: " + camion.CapacidadCarga1+"\n");


            SubClaseAutobus autobus;
            autobus = new SubClaseAutobus("Bogotá a Medellin",60.000);

            autobus.Nombre = "Volvo 9900 13.1 M.";
            autobus.Matricula1 = 247362;
            autobus.Marca = "Volvo Buses";
            autobus.Modelo = "6 x 2, 13.1 m";
            autobus.Cilindraje = "10,8 litros";
            autobus.Combustible = "Diesel";
            autobus.Ancho1 = 2.550;
            autobus.Largo1 = 13.100;
            autobus.CantRuedas = 6;
            autobus.Neumaticos1 = "'295/80 R22,5' o '315/80 R22,5'";
            autobus.Carroceria = "Volvo B8R";
            autobus.NumAsientos = 49;
            autobus.CapacidadDePasajeros = 49;
            autobus.Uso = "Publico";

            autobus.Rutas = "Bogotá a Medellin";
            autobus.ValorPasaje = 60.000;

            Console.WriteLine("\n~~~~~~~Autobus~~~~~~~");
            Console.WriteLine("~~~~~Propiedades~~~~~");
            Console.WriteLine("Nombre: "+autobus.Nombre);
            Console.WriteLine("Matricula: " + autobus.Matricula1);
            Console.WriteLine("Marca: " + autobus.Marca);
            Console.WriteLine("Modelo: " + autobus.Modelo);
            Console.WriteLine("Capacidad de cilindraje de: " + autobus.Cilindraje);
            Console.WriteLine("Combustible utilizado: " + autobus.Combustible);
            Console.WriteLine("El ancho es de " + autobus.Ancho1 + " metros.");
            Console.WriteLine("El largo es de " + autobus.Largo1 + " metros.");
            Console.WriteLine("Cuenta con " + autobus.CantRuedas + " ruedas.");
            Console.WriteLine("Neumaticos tipo: " + autobus.Neumaticos1);
            Console.WriteLine("Carroceria tipo " + autobus.Carroceria);
            Console.WriteLine("Tiene un total de " + autobus.NumAsientos + " asientos");
            Console.WriteLine("Capacidad de "+autobus.CapacidadDePasajeros+" pasajeros.");
            Console.WriteLine("Es de uso " + autobus.Uso);

            Console.WriteLine("La ruta es de "+autobus.Rutas);
            Console.WriteLine("El valor del pasaje es de: $"+autobus.ValorPasaje);
        }
    }
}
