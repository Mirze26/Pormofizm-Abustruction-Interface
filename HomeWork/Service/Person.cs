using HomeWork.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Service
{
    internal class Person : IPerson
    {
        public void GetName()
        {
            Console.WriteLine("Cavid");
        }
    }
}
