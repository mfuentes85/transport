using AutoTransport.Core;
using System.Media;
using System.Numerics;

namespace OOP.WinformApp
{
    public partial class Form1 : Form
    {
        Car car;
        Bus bus;



        public Form1()
        {
            InitializeComponent();

            car = new Car(4, 50, "VW Sedán");
            bus = new Bus(90, "Mercedes Benz");
            carGroupBox.Text = car.Name;
            groupBox2.Text = bus.Name;

            carLtsLabel.Text = $"{car.Lts} Litros";
            busLtsLabel.Text = $"{bus.Lts} Litros";

            if (car.IsOn)
            {
                onOffCarButton.Text = "Apagar";
            }
            else
            {
                onOffCarButton.Text = "Encender";
            }

            if (bus.IsOn)
            {
                onOffBusButton.Text = "Apagar";
            }
            else
            {
                onOffBusButton.Text = "Encender";
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            car.Name = "Jetta 2009";


            car.Sound();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            bus.Sound();

        }

        private void CarGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void carGasButton_Click(object sender, EventArgs e)
        {
            RechargeGas rechargeGas = new RechargeGas(car);

            rechargeGas.FormClosed += car_RechargeGas_FormClosed;

            rechargeGas.ShowDialog();
        }

        private void car_RechargeGas_FormClosed(object? sender, FormClosedEventArgs e)
        {
            carLtsLabel.Text = $"{car.Lts} Litros";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            RechargeGas rechargeGas = new RechargeGas(bus);

            rechargeGas.FormClosed += bus_RechargeGas_FormClosed;

            rechargeGas.ShowDialog();

        }
        private void bus_RechargeGas_FormClosed(object? sender, FormClosedEventArgs e)
        {
            busLtsLabel.Text = $"{bus.Lts} Litros";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void busLtsLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (car.IsOn)
            {
                car.IsOn = false;
                onOffCarButton.Text = "Encender";
            }
            else
            {
                car.IsOn = true;
                onOffCarButton.Text = "Apagar";
            }
        }

        private void onOffBusButton_Click(object sender, EventArgs e)
        {
            if (bus.IsOn)
            {
                bus.IsOn = false;
                onOffBusButton.Text = "Encender";
            }
            else
            {
                car.IsOn = true;
                onOffBusButton.Text = "Apagar";
            }
        }
    }
}
