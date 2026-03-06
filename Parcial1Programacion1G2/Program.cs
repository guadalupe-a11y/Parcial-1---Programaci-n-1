using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1Programacion1G2
{
    public class Vehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; }

        public Vehiculo(string marca, string modelo, int anio)
        {
            Marca = marca;
            Modelo = modelo;
            Anio = anio;
        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine("Vehículo:");
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Modelo: " + Modelo);
            Console.WriteLine("Año: " + Anio);
        }

        public virtual void Encender()
        {
            Console.WriteLine("El vehículo se está encendiendo...");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====================================");
            Console.WriteLine("   SISTEMA DE VEHICULOS - PARCIAL   ");
            Console.WriteLine("====================================");
            Console.WriteLine();

            // Lista de vehículos
            List<Vehiculo> vehiculos = new List<Vehiculo>();

            // Crear objetos de las clases hijas
            // `Carro` y `Moto` deben estar definidos únicamente en sus respectivos archivos (.cs).
            Carro miCarro = new Carro("Toyota", "Corolla", 2024, 4);
            Moto miMoto = new Moto("Honda", "CBR600RR", 2023, "600cc");

            // Agregar los objetos a la lista
            vehiculos.Add(miCarro);
            vehiculos.Add(miMoto);

            // Recorrer la lista usando foreach y llamar a los métodos
            foreach (Vehiculo v in vehiculos)
            {
                v.MostrarInformacion();
                v.Encender();
            }
            Console.WriteLine("------------------------------------");

            Console.WriteLine();
            Console.WriteLine("Programa finalizado.");
            Console.ReadKey();
        }
    }
}
