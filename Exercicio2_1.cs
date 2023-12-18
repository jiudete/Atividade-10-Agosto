using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_POOex2

{
    internal class Area

    {
        private double a1, a3;


        public void setA1(double x)
        {
            a1 = x;
        }

        public double getA1()
        {
            return a1;
        }

        public double getA3()
        {
            return a3;
        }

        public void Calcular()
        {
            a3 = Math.Pow(a1, 2);


        }
    }
}