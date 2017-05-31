using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosNoPlano
{
    class Program
    {
        static void Main(string[] args)
        {
             Objeto2D obj = new Objeto2D();

            Console.Write("Informe a posição inicial de X: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Informe a posição inicial de Y: ");
            int Y = int.Parse(Console.ReadLine());

           

            obj.x = Console.ReadLine();
            obj.y = Console.ReadLine();
            
           
                Console.Write("Informe o comando: ");
            ConsoleKey comando = Console.ReadKey().Key;

            if (comando == ConsoleKey.RightArrow)
            {
                obj.x += 
            }
        }
    }
}
