using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_CodigoMorse
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            { 
                int iniciar;
                Mensagem texto = new Mensagem();
                texto.texto = Console.ReadLine();
                string[] exibir = new string[texto.texto.Length];
                iniciar = int.Parse(Console.ReadLine());
                if (iniciar == 1)
                {
                    exibir = texto.codificar();
                    int i = 0;
                    while(i>texto.texto.Length)
                    {
                        Console.WriteLine(exibir[i]);
                    }
                }
        }
    }
}
