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
            string data, d, m, a;

            data = Console.ReadLine();

            d = data.Substring(0, 2);
            m = data.Substring(3, 2);
            a = data.Substring(6, 4);

            switch (m)
            {
                case "01":
                    m = "Janeiro";
                    break;

                case "02":
                    m = "Fevereiro";
                    break;

                case "03":
                    m = "Março";
                    break;

                case "04":
                    m = "Abril";
                    break;

                case "05":
                    m = "Maio";
                    break;

                case "06":
                    m = "Junho";
                    break;

                case "07":
                    m = "Julho";
                    break;

                case "08":
                    m = "Agosto";
                    break;

                case "09":
                    m = "Setembro";
                    break;

                case "10":
                    m = "Outubro";
                    break;

                case "11":
                    m = "Novembro";
                    break;

                case "12":
                    m = "Dezembro";
                    break;
            }

            Console.WriteLine("{0} de {1} de {2}", d, m, a);
        }
    }
}
