using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uczenie_maszynowe
{
    internal class Metody
    {
        double suma(double x1,double x2)
        {
            return x1 + x2;
        }
        int UniporalnaDys(double x1)
        {
            if (x1 > 0)
            {
                return 1;
            }
            else return 0;
        }
        int DipolarnaDys(double x1)
        {
            if (x1 > 0)
            {
                return 1;
            }
            else return 0;
        }
        double UnipolarnaCiogla (double x)
        {
            double output = 1 / 1 + Math.Exp(-1 * x);
            return output;
        }
        double DipolarnaCioglaSin(double x)
        {
            double output = (1 - Math.Exp(-1 * x))/ (1 + Math.Exp(-1 * x));
            return output;
        }

    }
}
