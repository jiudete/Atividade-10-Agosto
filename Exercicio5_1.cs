using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lista_POOex5
{
    internal class MilhaKm
    {
        #region atributos


        private double milhas, conversao;

        #endregion


        #region MetodoInterface
        public void SetMilhas(double m )
        {
             milhas = m;

        }
        public double GetMilhas()
        {
            return milhas ;
        
        }
        public double GetConversao()
        {
            return conversao;

        }
        
        #endregion

        #region MetodoFuncionais 

        
       
        
        public void Converter()
        {
            conversao = milhas * 1.852;

        }
        #endregion

        
       
        
    }
  

}





