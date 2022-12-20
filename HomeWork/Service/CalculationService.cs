using HomeWork.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Service

{
    internal class CalculationService : ICalculationService
    {
        public void Calculate(double num1, double num2)
        {
            double sum;
            sum = num1 + num2;
            Console.WriteLine(sum);
            double subtraction;
            subtraction = num1 - num2;
            Console.WriteLine(subtraction);
            double multiplication;
            multiplication = num1 * num2;
            Console.WriteLine(multiplication);
            double division;
            division = num1 / num2;
            Console.WriteLine(division);

        }

    }
}   
