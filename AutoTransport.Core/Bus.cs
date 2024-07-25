using AutoTransport.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace AutoTransport.Core
{
   
        public class Bus : Transport
        {
            public Bus(int capacity, string name)
            {
                LtsCapacity = capacity;
                Lts = 0;
                IsOn = false;
                Name = name;
            Performance = 8;
                SoundFileName = "bocinaBus.wav";

               }


        }


    }