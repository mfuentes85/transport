
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
        public double Performance { get; set; }

        protected string SoundFileName { get; set; }

        public event EventHandler<string> OnConsoleLog;



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
                    OnConsoleLog(this, $"{Name} ** Incia a correr con {Lts} litros");
                    //Console.WriteLine($"{Name} ** Incia a correr con {Lts} litros");
                    //Console.WriteLine($"{Name} ** Este auto tiene {Cilinders} cilindros");
                   
                     OnConsoleLog(this, $"{Name} ** Y almacena {LtsCapacity} litros de gasolina");
                    //Console.WriteLine($"{Name} ** Y almacena {LtsCapacity} litros de gasolina");

                    IsOn = true;

                    double consumo = (kilometer / Performance);

                    if ((consumo <= Lts))  // Si alcanza el combustible
                    {
                        Lts = Lts - consumo;

                        OnConsoleLog(this, $"{Name} **Se recorrieron {kilometer} kilómetros y restan {Lts} litros de gasolina");

                        //Console.WriteLine($"{Name} **Se recorrieron {kilometer} kilómetros y restan {Lts} litros de gasolina");

                    }
                    else
                    {
                        double KmRecorridos = Performance * Lts;

                        OnConsoleLog(this, $"{Name} **Se recorrieron {KmRecorridos} kilometros y se agotó la gasolina");
                        //Console.WriteLine($"{Name} **Se recorrieron {KmRecorridos} kilometros y se agotó la gasolina");

                    }

                }
                else
                {
                    OnConsoleLog(this, $"{Name} ** No se puede iniciar porque el tanque está vacío");
                    //Console.WriteLine($"{Name} ** No se puede iniciar porque el tanque está vacío");
                    IsOn = false;

                }
            }

        }

        protected void ConsoleLog (string text)
        {
            OnConsoleLog (this, text);
        }

    }

}