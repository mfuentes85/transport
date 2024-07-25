using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;


namespace AutoTransport.Core
{
    public class Car: Transport
    {
        public int Cilinders {  get; set; }


        public Car(int cilinders, int capacity, string name)
        {
            Cilinders = cilinders;
            LtsCapacity = capacity;
            Lts = 0;
            Name = name;
            SoundFileName = "bocinaCar.wav";

            switch (cilinders)
            {
                case 4:
                    Performance = 15; break;
                case 6:
                    Performance = 11; break;
                case 8:
                    Performance = 8; break;
                case 12:
                    Performance = 6; break;

                default:

                    ConsoleLog($"{Name} ** Cantidad de cilindros inválida");
                        //Console.WriteLine($"{Name} ** Cantidad de cilindros inválida"); break;
                    break;                        
            }
        }


    }


}
