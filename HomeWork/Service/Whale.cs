using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Service
{
    internal class Whale : Animals
    {
       public int TeethCount { get; set; }

        public override void Sound()
        {
            Console.WriteLine("Whale sound");
        }


    }
}
