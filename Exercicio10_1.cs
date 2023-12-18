using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_POOex10
{
    internal class CalcularImc
    #region atributos
    {
        private double peso, altura, imc, acima, baixo, ideal;
    
    #endregion
    #region MetodosInterface 
      public void SetPeso(double p)
      {
        peso = p;
      }
      public void SetAltura(double a)
      {
       altura = a; 
      }
      public double GetPeso()
       
      {
        return peso;
      }

      public double GetAltura()
      {
        return altura;
      }
      public double GetImc()
      { 
        return imc;
      }
        public double GetBaixo()
        {
            return baixo; 
        }
        public double GetAcima()
        {
            return acima;
        }
        public double GetIdeal() 
        {
            return ideal;
        }

        #endregion
        #region MetodosFuncionais
        public void ResultadoImc() 
        {
           imc = peso / (altura * altura);
        
            
                
            
        
        }
        #endregion





















    }
}