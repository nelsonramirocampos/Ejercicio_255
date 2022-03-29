using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio255
{
    class Distribucion
    {
        public static Double uniforme(double RND, double A, double B)
        {
            return B + RND * (B - A);
        }
    }
}
