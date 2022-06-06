using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class SuperClaseVehiculos
    {
        private string nombre;
        private int Matricula;
        private double precio;
        private string marca;
        private string modelo;
        private string color;
        private string cilindraje;
        private string combustible;
        private double Largo;
        private double Ancho;

        public SuperClaseVehiculos(string nombre, int matricula, double precio, string marca, string modelo, string color, string cilindraje, string combustible, double largo, double ancho)
        {
            this.nombre = nombre;
            this.Matricula = matricula;
            this.precio = precio;
            this.marca = marca;
            this.modelo = modelo;
            this.color = color;
            this.cilindraje = cilindraje;
            this.combustible = combustible;
            this.Largo = largo;
            this.Ancho = ancho;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Matricula1 { get => Matricula; set => Matricula = value; }
        public double Precio { get => precio; set => precio = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Color { get => color; set => color = value; }
        public string Cilindraje { get => cilindraje; set => cilindraje = value; }
        public string Combustible { get => combustible; set => combustible = value; }
        public double Largo1 { get => Largo; set => Largo = value; }
        public double Ancho1 { get => Ancho; set => Ancho = value; }
    }
}
