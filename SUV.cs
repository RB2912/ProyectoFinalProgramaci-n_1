using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProgramación_1
{
    internal class SUV : VehiculoBase
    {
        public int CapacidadPasajeros { get; set; }
        public bool TraccionTotal { get; set; }
        public bool Encendido { get; private set; }

        public override int VelocidadMaxima => 200;

        public void ActivarModo4x4()
        {
            if (TraccionTotal)
            {
                Console.WriteLine("El modo 4x4 ha sido activado.");
            }
            else
            {
                Console.WriteLine("Este SUV no tiene tracción total.");
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
