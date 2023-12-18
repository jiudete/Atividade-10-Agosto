using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lista_POOex3
{
    internal class Diagonal
    {
        double d1, d3;

        public void setD1(double d)

        {
            d1 = d;
        }

        public double getD1()
        {
            return d1;

        }

        public double getD3()
        {
            return d3;

        }
        public void Calcular()
        {
            d3 = d1 * (Math.Pow(d1, 2));
        }
    }  
}
