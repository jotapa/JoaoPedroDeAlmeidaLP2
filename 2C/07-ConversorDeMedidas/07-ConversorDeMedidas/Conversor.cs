using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ConversorDeMedidas
{
    class Conversor
    {
        public static double c, f, k;
        public static double km, m, Cm, pes, pol;
        public static double kg, g, lb, ton;

        public static double convertcpf(double x)
        {
            c = x;
            return f = (c * 1.8) + 32;
        }

        public static double convertcpk(double x)
        {
            k = x;
            return k = c + 273;

        }
        public static double convertkpc(double x)
        {
            c = x;
            return c = k - 273;
        }
        public static double convertfpc(double x)
        {
            f = x;
            return c = (f - 32) / 1.8;

        }
        public static double convertfpk(double x)
        {
            f = x;
            return k = (f - 32 / 1.8) + 273;

        }
        public static double convertkpf(double x)
        {
            k = x;
            return f = (k * 1.8) - 459.67;
        }
        public static double convertmpkm(double x)
        {
            m = x;
            return km = m / 1000;
        }
        public static double convertkmpm(double x)
        {
            km = x;
            return m = km * 1000;
        }
        public static double convertmpcm(double x)
        {
            m = x;
            return Cm = m * 100;

        }
        public static double convertcmpm(double x)
        {
            Cm = x;
            return Cm = m * 100;
        }
        public static double convertkmpcm(double x)
        {
            km = x;
            return Cm = km * 100000;
        }
        public static double convertcmpkm(double x)
        {
            Cm = x;
            return km = Cm / 100000;
        }
        public static double convertcmppol(double x)
        {
            Cm = x;
            return pol = Cm / 0.3937;
        }
        public static double convertmppol(double x)
        {
            m = x;
            return pol = m * 39.3701;

        }
        public static double convertkmppol(double x)
        {
            km = x;
            return pol = km * 39370.1;
        }
        public static double convertpolpm(double x)
        {
            pol = x;
            return m = pol * 0.0254;
        }
        public static double convertpolpkm(double x)
        {
            pol = x;
            return km = pol * 0.0000254;
        }
        public static double convertpolpcm(double x)
        {
            pol = x;
            return Cm = pol * 2.54;
        }
        public static double convertkmppes(double x)
        {
            km = x;
            return pes = km * 3280.84;
        }
        public static double convertcmppes(double x)
        {
            Cm = x;
            return pes = Cm / 0.0328;
        }
        public static double convertmppes(double x)
        {
            m = x;
            return pes = m * 3.2808;
        }
        public static double convertpespm(double x)
        {
            pes = x;
            return m = pes * 0.3048;
        }
        public static double convertpespkm(double x)
        {
            pes = x;
            return km = pes * 0.0003048;
        }
        public static double convertpespcm(double x)
        {
            pes = x;
            return Cm = pes * 30.48;
        }
        public static double convertpesppol(double x)
        {
            pes = x;
            return pol = pes * 12;
        }
        public static double convertpolppes(double x)
        {
            pol = x;
            return pes = pol * 0.83333;
        }
        public static double convertonpkg(double x)
        {
            ton = x;
            return kg = ton / 1000;

        }
        public static double convertonpg(double x)
        {
            ton = x;
            return g = ton / 1000000;
        }
        public static double convertkgpton(double x)
        {
            kg = x;
            return ton = kg * 1000;
        }
        public static double convertpton(double x)
        {
            g = x;
            return ton = g * 1000000;
        }
        public static double convertgplb(double x)
        {
            lb = x;
            return g = lb / 0.0022046;
        }
        public static double convertlbpg(double x)
        {
            g = x;
            return lb = g * 0.00220462;
        }
        public static double convertlbpkg(double x)
        {
            kg = x;
            return lb = kg * 2.20462;

        }
        public static double convertkgplb(double x)
        {
            lb = x;
            return kg = lb / 2.20462;

        }
        public static double convertlbpton(double x)
        {
            ton = x;
            return lb = ton * 2024.62;
        }
        public static double convertonplb(double x)
        {
            lb = x;
            return ton = lb / 2024.62;
        }
    }
}
