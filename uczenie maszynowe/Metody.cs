using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uczenie_maszynowe
{
    public class Metody
    {

        public int UniporalnaDys(double x1)
        {
            if (x1 > 0)
            {
                return 1;
            }
            else return 0;
        }
        public double DipolarnaDys(double x1)
        {
            if (x1 > 0)
            {
                return 1;
            }
            else return 0;
        }
        public double UnipolarnaCiogla (double x)
        {
            double output = 1 / 1 + Math.Exp(-1 * x);
            return output;
        }
        public double DipolarnaCioglaSin(double x)
        {
            double output = (1 - Math.Exp(-1 * x))/ (1 + Math.Exp(-1 * x));
            return output;
        }

    }
}
