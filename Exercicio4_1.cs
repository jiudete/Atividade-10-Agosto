using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_POOex4
{
    internal class AreaTriangular
    {
        private double b, h, t;

        public void SetB(double e)
        {
            b = e;
        }
        public void SetH(double e)
        {
            h = e;
        }
        public double GetB()

        {
            return b;
        }

        public double GetH()

        {
            return h;
        }
        public double GetT()
        {
            return t;

        }
        public void Calculo()
        {
            t = (b * h / 2);
        }
    }
}

