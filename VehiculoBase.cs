using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProgramación_1
{
    internal class VehiculoBase : IVehiculo
    {
        private bool encendido;
        private int velocidadActual;

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public int Anio { get; set; }
        public string Placa { get; set; }
        public string Tipo { get; set; }
        public virtual int VelocidadMaxima { get; }
        public int VelocidadActual
        {
            get { return velocidadActual; }
            protected set { velocidadActual = value; }
        }

        public void Bocina()
        {
            Console.WriteLine("¡Beep beep!");
        }
         public void Acelerar(int cuanto)
        {
            if (encendido)
            {
                VelocidadActual += cuanto;
                if (VelocidadActual > VelocidadMaxima)
                {
                    VelocidadActual = VelocidadMaxima;
                }
            }
            else
            {
                Console.WriteLine("El vehículo está apagado. No se puede acelerar.");
            }
        }

        public void Encender()
        {
            encendido = true;
            Console.WriteLine("El vehículo ha sido encendido.");
        }

        public void Apagar()
        {
            encendido = false;
            VelocidadActual = 0;
            Console.WriteLine("El vehículo ha sido apagado.");
        }

        public void Frenar(int cuanto)
        {
            if (encendido)
            {
                VelocidadActual -= cuanto;
                if (VelocidadActual < 0)
                {
                    VelocidadActual = 0;
                }
            }
            else
            {
                Console.WriteLine("El vehículo está apagado. No se puede frenar.");
            }
        }
    }

}
