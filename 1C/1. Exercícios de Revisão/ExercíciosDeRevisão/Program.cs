using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correção_Revisão_de_Subrotinas
{
    class Program
    {
            public struct Carro
            {
                public string modelo;
                public double km, AnoDeFabri;
                public int pot;
            }
            public static void Main(string[] args)
        {            
            Console.WriteLine("Informe o número de carros do galpão");
            int n = int.Parse(Console.ReadLine());
            Carro[] carros = new Carro[n];    

            for (int i = 0; i < n; i++)
            {
                carros[i].modelo = Console.ReadLine(); 
                carros[i].km = double.Parse(Console.ReadLine()); 
                carros[i].pot = int.Parse(Console.ReadLine());
            }
            
                for (int i = 0; i < n; i++)
                Console.WriteLine(Classificar(carros[i]));
        }


        public static string Classificar(Carro c)
        {
            string tipo, p;
            
            if (c.km <= 5000)
                tipo = "novo";
            else if (c.km <= 30000)
                tipo = "semi novo";
            else
                tipo = "velho";
            
            if (c.pot > 200)
                p = "potente";
            else if (c.pot >= 120 && c.pot <= 200)
                p = "forte";
            else
                p = "popular";
            return String.Format("{0} - {1} - {2}", c.modelo, tipo, p);
             
        
       }
        public static void atualizarKm (Carro c1, double novo)
        {
            c1.km = novo;
        }
        
        public static double TaxaDeUsoCarro (Carro c)
        {
            return c.km / (DateTime.Now.Year - c.AnoDeFabri);
        }
       
    }
}