using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lista_POOex2 
{ 
    internal class program
    { 
        static void Main(string[] args)
        {
            Area q;
            q = new Area();

            q.setA1(8);
            q.Calcular();

            Console.WriteLine(" A área do quardro é {1}", q.getA1(), q.getA3());


        }



    }
        

}
