using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_POOex1
{

    internal class Area
    {
        private int b, h;     
        public Area(int b,int h )
        { 
            this.b = b;
            this.h = h;
        }
        public int CalculoArea()
        {
            int area = this.b * this.h;
            return area;
        }

    }
}