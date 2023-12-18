using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_POOex4
{
   internal class program
   {
        static void Main(string[] args)
        {
         AreaTriangular r = new AreaTriangular();
            r.SetB(4);
            r.SetH(5);
            r.Calculo();

            Console.WriteLine(" A área triangular é {2}", r.GetB(),r.GetH(),r.GetT());
        }
   }
}
