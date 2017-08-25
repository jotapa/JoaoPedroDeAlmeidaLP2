using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3__Temperatura
{
    class Program
    {
        static void Main(string[] args)
        {
           
            TemperaturaCelsius temp = new TemperaturaCelsius();
            double convert = double.Parse(Console.ReadLine());
            temp.Fahrenheit();
        }
    }
}
