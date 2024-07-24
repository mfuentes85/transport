
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;  
using System.Text;
using System.Threading.Tasks;


namespace AutoTransport.Core 
{

    public class Transport
    {
        public int LtsCapacity { get; set; }

        public double Lts { get; set; }

        public string Name { get; set; }

        /// <summary>
        /// Indica si el vehículo está en marcha
        /// </summary>
        public bool IsOn { get; set; }
        /// <summary>
        /// Cantidad de kilometros que recorre por litro
        /// </summary>
        public int Performance { get; set; }

        protected string SoundFileName { get; set; }



        /// <summary>
        /// Sonido de Claxon / corneta
        /// </summary>
        public void Sound()
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\Administrador\Downloads\"+ SoundFileName);
            player.Play();

        }

        public void Run(double kilometer)


        {
            if (Performance == 0)
            {


                // Console.WriteLine($"{Name} ** No se puede arrancar, cilindros inválidos: {  Cilinders}");
            }
            else
            {

                if (Lts > 0)
                {
                    Console.WriteLine($"{Name} ** Incia a correr con {Lts} litros");
                    //Console.WriteLine($"{Name} ** Este auto tiene {Cilinders} cilindros");
                    Console.WriteLine($"{Name} ** Y almacena {LtsCapacity} litros de gasolina");
                    IsOn = true;

                    double consumo = (kilometer / Performance);

                    if ((consumo <= Lts))
                    {
                        Lts = Lts - consumo;

                        Console.WriteLine($"{Name} **Se recorrieron {kilometer} kilómetros y restan {Lts} litros de gasolina");

                    }
                    else
                    {
                        double KmRecorridos = Performance * Lts;


                        Console.WriteLine($"{Name} **Se recorrieron {KmRecorridos} kilometros y se agotó la gasolina");

                    }

                }
                else
                {
                    Console.WriteLine($"{Name} ** No se puede iniciar porque el tanque está vacío");
                    IsOn = false;

                }
            }

        }



    }

}