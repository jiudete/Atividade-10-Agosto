using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_POOex9
{

    internal class Area
    {
        private int b, h, a;

        public void Setb(int n)
        {
            b = n;
        }
        public void Seth(int n)
        {
            h = n;
        }
        public int Getb()
        {
            return b;

        }
        public int Geth()
        {
            return h;
        }
        public int Geta()
        {
            return a;
        }
        public void Calcular()

        {
            a = b * h;
            if (a > 100)
            { Console.WriteLine("Terreno grande"); }
            if (a < 100)
            { Console.WriteLine("Terreno Pequeno"); }
        }

    }
}


