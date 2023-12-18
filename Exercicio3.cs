using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_POOex3
{
    internal class program
    { 
     

        static void Main(string[] args)
        {
            Diagonal d = new Diagonal();
            d.setD1(25);
            d.Calcular();

            Console.WriteLine("A diagonal do quadrado é {1}", d.getD1(), d.getD3());
        }
    }
}
