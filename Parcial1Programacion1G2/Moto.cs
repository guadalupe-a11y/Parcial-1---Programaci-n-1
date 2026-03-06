using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1Programacion1G2
{
    // Se asume que existe una clase base `Vehiculo` con:
    // - constructor: Vehiculo(string marca, string modelo, int anio)
    // - miembros virtuales: MostrarInformacion(), Encender()
    public class Moto : Vehiculo
    {
        // Atributo adicional requerido [cite: 36]
        public string Cilindraje { get; set; }

        // Constructor
        public Moto(string marca, string modelo, int anio, string cilindraje)
            : base(marca, modelo, anio)
        {
            Cilindraje = cilindraje;
        }

        // Sobrescribir MostrarInformacion [cite: 37]
        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("Cilindraje: " + Cilindraje);
        }

        // Sobrescribir Encender [cite: 38]
        public override void Encender()
        {
            Console.WriteLine($"La moto {Marca} {Modelo} está encendiendo por arranque eléctrico...");
        }
    }
}
