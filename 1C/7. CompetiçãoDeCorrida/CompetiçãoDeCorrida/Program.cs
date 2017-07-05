using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetiçãoDeCorrida
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Qual o número de competidores?");
            int n = int.Parse(Console.ReadLine());
            Speedster Campeão = new Speedster();
            Campeão.PrimeiraVez = double.MaxValue;
            Campeão.SegundaVez = double.MaxValue;
            Campeão.TerceiraVez = double.MaxValue;

            Speedster[] Velocistas = new Speedster[n];

            for (int i = 0; i < n; i++)
            {
                Velocistas[i] = new Speedster();
                Console.WriteLine("Qual o nome do competidor(a) {0}?", i+1);
                Velocistas[i].Nome = Console.ReadLine();

            }

            for (int i = 0; i < n; i++)
            {
                Speedster[] Aluno = new Speedster[i];

                Console.WriteLine("Quantos metros o(a) {0}º competidor(a) correu na 1ª etapa?", i + 1);
                Velocistas[i].PrimeiraVez = double.Parse(Console.ReadLine());

                Console.WriteLine("Quantos metros o(a) {0}º competidor(a) correu na 2ª etapa?", i + 1);
                Velocistas[i].SegundaVez = double.Parse(Console.ReadLine());

                Console.WriteLine("Quantos metros o(a) {0}º competidor(a) correu na 3ª etapa?", i + 1);
                Velocistas[i].TerceiraVez = double.Parse(Console.ReadLine());

                if (Velocistas[i].TempoOficial() < Campeão.TempoOficial())
                    Campeão = Velocistas[i];
            }
            Console.WriteLine(Campeão.Nome);
         }







    }
}