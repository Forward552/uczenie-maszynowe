using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uczenie_maszynowe
{
    public class Metody
    {

        public int UniporalnaDys(double net)
        {
            if (net > 0)
            {
                return 1;
            }
            else return 0;
        }
        public double DipolarnaDys(double net)
        {
            if (net > 0)
            {
                return 1;
            }
            else return -1;
        }
        public double UnipolarnaCiogla (double net)
        {
            double output = 1 / 1 + Math.Exp(-1 * net);
            return output;
        }
        public double DipolarnaCioglaSin(double net)
        {
            double output = (1 - Math.Exp(-1 * net))/ (1 + Math.Exp(-1 * net));
            return output;
        }

    }
}
