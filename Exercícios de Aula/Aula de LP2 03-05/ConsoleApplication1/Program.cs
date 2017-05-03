using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string j;
            int cont = 0;
            j = Console.ReadLine().ToLower();

            for(int i = 0; i < j.Length; i++)
            {
                if (j[i] == 'a')
                    cont++;
                else if (j[i] == 'e')
                    cont++;
                else if (j[i] == 'i')
                    cont++;
                else if (j[i] == 'o')
                    cont++;
                else if (j[i] == 'u')
                    cont++;
            }
            Console.WriteLine("A mensagem tem {0} vogais", cont);

        }
    }
}
