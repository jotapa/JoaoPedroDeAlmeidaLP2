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
            string c, p, modelo, t;
            double km, cv;
            int n;

            Console.WriteLine("Informe o número de veículos no galpão");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Qual o modelo do veículo?");
                modelo = Console.ReadLine();

                Console.WriteLine("Informe a quilometragem rodada");
                km = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Qual a potência do motor?");
                cv = Double.Parse(Console.ReadLine());
            }
                

            c = classificar;
            Console.WriteLine("{0} - {1} - {2}", modelo, t, p);
        }


        static string classificar(string modelo; string t; string p;)
        {
            string tipo, p;
            int km, cv;
            
            if (km <= 5000)
                {
                        tipo = "novo";
                }
                else if (km > 5000 && km <= 30000)
                {
                        tipo = "semi novo";
                }
                else
                {
                       tipo = "velho";
                }
            
              if (cv > 200)
              {
                        p = "potente";
              }
              else if (cv >= 120 && cv <= 200)
              {
                        p = "forte";
              }
              else
              {
                        p = "popular";
              }
                return tipo, p;
        
       }

       
    }
}

