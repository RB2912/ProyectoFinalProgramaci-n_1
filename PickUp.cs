using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProgramación_1
{
    internal class PickUp : VehiculoBase
    {
        public int CapacidadCarga { get; set; }
        public bool DobleCabina { get; set; }
        public bool Encendido { get; private set; }

        public override int VelocidadMaxima => 190;

        public void CargarMercancia(int cantidad)
        {
            if (cantidad <= CapacidadCarga)
            {
                Console.WriteLine($"Se ha cargado {cantidad} kg de mercancía.");
            }
            else
            {
                Console.WriteLine("La carga excede la capacidad de carga de la pick-up.");
            }
        }

        public void Encender()
        {
            if (!Encendido)
            {
                Encendido = true;
                Console.WriteLine("El carro ha sido encendido.");
            }
            else
            {
                Console.WriteLine("El carro ya está encendido.");
            }
        }

        public void Apagar()
        {
            if (Encendido)
            {
                Encendido = false;
                Console.WriteLine("El carro ha sido apagado.");
            }
            else
            {
                Console.WriteLine("El carro ya está apagado.");
            }
        }

        public int VelocidadActual { get; set; }

        public void Acelerar(int velocidad)
        {
            if (Encendido)
            {
                VelocidadActual += velocidad;
            }
            else
            {
                Console.WriteLine("No se puede acelerar. El carro está apagado.");
            }
        }

        public void Frenar(int velocidad)
        {
            if (Encendido)
            {
                VelocidadActual -= velocidad;
                if (VelocidadActual < 0)
                    VelocidadActual = 0;
            }
            else
            {
                Console.WriteLine("No se puede frenar. El carro está apagado.");
            }
        }
    }
}
