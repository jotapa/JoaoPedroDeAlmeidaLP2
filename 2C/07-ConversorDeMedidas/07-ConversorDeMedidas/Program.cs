using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ConversorDeMedidas
{
    class Program
    {
        static void Main(string[] args)
        {
            double temp = 0;
            Console.WriteLine("A qual distância você está? ");
            temp = int.Parse(Console.ReadLine());
            int tipo;
            Console.WriteLine("Os tipos de temperatura: de celsius para farenheit: (1), de farenheit para celsius: (2), de celsius para kelvin: (3), de kelvin para celsius (4), de kelvin para farenheit (5), de farenheit para kelvin (6)");
            tipo = int.Parse(Console.ReadLine());
            if (tipo == 1)
            {
                Console.WriteLine(Conversor.convertcpf(temp));

            }
            else if (tipo == 2)
            {
                Console.WriteLine(Conversor.convertfpc(temp));

            }
            else if (tipo == 3)
            {
                Console.WriteLine(Conversor.convertcpk(temp));

            }
            else if (tipo == 4)
            {
                Console.WriteLine(Conversor.convertkpc(temp));

            }
            else if (tipo == 5)
            {
                Console.WriteLine(Conversor.convertkpf(temp));


            }
            else if (tipo == 6)
            {
                Console.WriteLine(Conversor.convertfpk(temp));

            } 
        }
    }
}
