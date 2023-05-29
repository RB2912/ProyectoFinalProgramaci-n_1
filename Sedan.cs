using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProgramación_1
{
    internal class Sedan : VehiculoBase
    {
        public int NumeroPuertas { get; set; }
        public bool Convertible { get; set; }
        public bool Encendido { get; private set; }

        public override int VelocidadMaxima => 180;

        public void AbrirTechoSolar()
        {
            if (Convertible)
            {
                Console.WriteLine("El techo solar ha sido abierto.");
            }
            else
            {
                Console.WriteLine("Este sedán no tiene techo solar.");
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
