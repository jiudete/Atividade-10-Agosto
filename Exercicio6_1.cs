using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_POOex6
{

    internal class CotaDollar
    {
        #region Atributos

        private double cd, d, converter;
       

        #endregion

        #region MetodosInterface

        public void SetD(double dc)
        {

            d = dc;

        }
        public void SetCd(double v)
        {
        
        cd = v;
        
        }
        
       
         
        public double GetD()
        {

            return d;
        }

        public double GetCd()
        {

            return cd;

        }
        public double GetConverter()
        {
            return converter;   
        }

   
     

    
      
        #endregion


        #region MetodosFuncionais

        public void Conversor()

        {

            converter = d * cd;

        }
        
    }
        #endregion
}


