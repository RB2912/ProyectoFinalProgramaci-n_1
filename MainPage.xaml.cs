using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProgramación_1
{
    public partial class MainPage : ContentPage
    {
        private Sedan sedan;
        private SUV suv;
        private _4X4 vehiculo4x4;
        private PickUp pickUp;

        public MainPage()
        {
            InitializeComponent();
            sedan = new Sedan();
            suv = new SUV();
            vehiculo4x4 = new _4X4();
            pickUp = new PickUp();
        }

        private void SedanAccelerateBtn_Clicked(object sender, EventArgs e)
        {
            if (sedan.Encendido)
            {
                sedan.Acelerar(10);
                SedanSpeedLabel.Text = $"Current Speed: {sedan.VelocidadActual} km/h";
            }
            else
            {
                Console.WriteLine("No se puede acelerar. El sedan está apagado.");
            }
        }

        private void SedanBrakeBtn_Clicked(object sender, EventArgs e)
        {
            if (sedan.Encendido)
            {
                sedan.Frenar(5);
                SedanSpeedLabel.Text = $"Current Speed: {sedan.VelocidadActual} km/h";
            }
            else
            {
                Console.WriteLine("No se puede frenar. El sedan está apagado.");
            }
        }

        private void SUVAccelerateBtn_Clicked(object sender, EventArgs e)
        {
            if (suv.Encendido)
            {
                suv.Acelerar(10);
                SUVSpeedLabel.Text = $"Current Speed: {suv.VelocidadActual} km/h";
            }
            else
            {
                Console.WriteLine("No se puede acelerar. El SUV está apagado.");
            }
        }

        private void SUVBrakeBtn_Clicked(object sender, EventArgs e)
        {
            if (suv.Encendido)
            {
                suv.Frenar(5);
                SUVSpeedLabel.Text = $"Current Speed: {suv.VelocidadActual} km/h";
            }
            else
            {
                Console.WriteLine("No se puede frenar. El SUV está apagado.");
            }
        }

        private void _4x4AccelerateBtn_Clicked(object sender, EventArgs e)
        {
            if (vehiculo4x4.Encendido)
            {
                vehiculo4x4.Acelerar(10);
                _4x4SpeedLabel.Text = $"Current Speed: {vehiculo4x4.VelocidadActual} km/h";
            }
            else
            {
                Console.WriteLine("No se puede acelerar. El vehículo 4x4 está apagado.");
            }
        }

        private void _4x4BrakeBtn_Clicked(object sender, EventArgs e)
        {
            if (vehiculo4x4.Encendido)
            {
                vehiculo4x4.Frenar(5);
                _4x4SpeedLabel.Text = $"Current Speed: {vehiculo4x4.VelocidadActual} km/h";
            }
            else
            {
                Console.WriteLine("No se puede frenar. El vehículo 4x4 está apagado.");
            }
        }

        private void PickUpAccelerateBtn_Clicked(object sender, EventArgs e)
        {
            if (pickUp.Encendido)
            {
                pickUp.Acelerar(10);
                PickUpSpeedLabel.Text = $"Current Speed: {pickUp.VelocidadActual} km/h";
            }
            else
            {
                Console.WriteLine("No se puede acelerar. La pick-up está apagada.");
            }
        }

        private void PickUpBrakeBtn_Clicked(object sender, EventArgs e)
        {
            if (pickUp.Encendido)
            {
                pickUp.Frenar(5);
                PickUpSpeedLabel.Text = $"Current Speed: {pickUp.VelocidadActual} km/h";
            }
            else
            {
                Console.WriteLine("No se puede frenar. La pick-up está apagada.");
            }
        }

        private void SedanTurnOnBtn_Clicked(object sender, EventArgs e)
        {
            if (!sedan.Encendido)
            {
                sedan.Encender();
            }
            else
            {
                Console.WriteLine("El sedan ya está encendido.");
            }
        }

        private void SedanTurnOffBtn_Clicked(object sender, EventArgs e)
        {
            if (sedan.Encendido)
            {
                sedan.Apagar();
            }
            else
            {
                Console.WriteLine("El sedan ya está apagado.");
            }
        }

        private void SUVTurnOnBtn_Clicked(object sender, EventArgs e)
        {
            if (!suv.Encendido)
            {
                suv.Encender();
            }
            else
            {
                Console.WriteLine("El SUV ya está encendido.");
            }
        }

        private void SUVTurnOffBtn_Clicked(object sender, EventArgs e)
        {
            if (suv.Encendido)
            {
                suv.Apagar();
            }
            else
            {
                Console.WriteLine("El SUV ya está apagado.");
            }
        }

        private void _4x4TurnOnBtn_Clicked(object sender, EventArgs e)
        {
            if (!vehiculo4x4.Encendido)
            {
                vehiculo4x4.Encender();
            }
            else
            {
                Console.WriteLine("El vehículo 4x4 ya está encendido.");
            }
        }

        private void _4x4TurnOffBtn_Clicked(object sender, EventArgs e)
        {
            if (vehiculo4x4.Encendido)
            {
                vehiculo4x4.Apagar();
            }
            else
            {
                Console.WriteLine("El vehículo 4x4 ya está apagado.");
            }
        }

        private void PickUpTurnOnBtn_Clicked(object sender, EventArgs e)
        {
            if (!pickUp.Encendido)
            {
                pickUp.Encender();
            }
            else
            {
                Console.WriteLine("La pick-up ya está encendida.");
            }
        }

        private void PickUpTurnOffBtn_Clicked(object sender, EventArgs e)
        {
            if (pickUp.Encendido)
            {
                pickUp.Apagar();
            }
            else
            {
                Console.WriteLine("La pick-up ya está apagada.");
            }
        }
    }
}
