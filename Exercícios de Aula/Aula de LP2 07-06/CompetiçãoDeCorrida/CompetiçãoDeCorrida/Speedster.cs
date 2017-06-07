using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetiçãoDeCorrida
{
    class Speedster
    {
        public string Nome;
        public double PrimeiraVez;
        public double SegundaVez;
        public double TerceiraVez;

        public double TempoOficial()
        {
            double[] temp = new double[3] { PrimeiraVez, SegundaVez, TerceiraVez };
            Array.Sort(temp);
            return temp[0] + temp[1];
        }
    }
}
