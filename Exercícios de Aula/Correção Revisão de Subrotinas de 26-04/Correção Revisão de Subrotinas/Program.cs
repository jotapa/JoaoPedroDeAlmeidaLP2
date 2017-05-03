using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correção_Revisão_de_Subrotinas
{
    class Program
    {
            public static void Main(string[] args)
        {            
            Console.WriteLine("Informe o número de carros do galpão");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Informe o modelo do carro");
                string nome = Console.ReadLine();
                Console.WriteLine("Informe a quilometragem rodada");
                double km = double.Parse(Console.ReadLine());
                Console.WriteLine("Informe a potência do carro");
                int poten = int.Parse(Console.ReadLine());

                Console.WriteLine(classificar(nome, km, poten));
            }
        }


        public static string classificar(string modelo, double km, int pot)
        {
            string tipo, p;
            
            if (km <= 5000)
                tipo = "novo";
            else if (km <= 30000)
                tipo = "semi novo";
            else
                tipo = "velho";
            
            if (pot > 200)
                p = "potente";
            else if (pot >= 120 && pot <= 200)
                p = "forte";
            else
                p = "popular";
            return String.Format("{0} - {1} - {2}", modelo, tipo, p);
             
        
       }

       
    }
}