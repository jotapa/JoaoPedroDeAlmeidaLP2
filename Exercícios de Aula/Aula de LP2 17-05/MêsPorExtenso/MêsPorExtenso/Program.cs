using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MêsPorExtenso
{
    class Program
    {
        static void Main(string[] args)
        {
            int d, m, a;
            string data;

            string dt = Console.ReadLine();
            string sóMês = data.Substring(4,2);

            
            switch (m)
            {
                case 01:

                    data = "janeiro";

                    break;

                case 02:
                    data = "fevereiro";

                    break;
                   
                case 03:
                    
                    data = "março";
                    break;

                case 04:
                    
                    data = "abril";
                    break;

                case 05:
                    data = "maio";
                    break;

                case 06:
                    data = "junho";
                    break;

                case 07:
                    data = "julho";
                    break;

                case 08: 
                    data = "agosto";
                    break;

                case 09:
                    data = "setembro";
                    break;

                case 10:
                    data = "outubro";
                    break;

                case 11:
                    data = "novembro";
                    break;

                case 12:
                    data = "dezembro";
                    break;

            }
            Console.WriteLine("{0} de {1} de {2}" d, m, a);
        }
    }
}
