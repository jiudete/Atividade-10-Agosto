using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Lista_POOex8
{
    internal class Numeros
    #region atributos
    {
        private int valor1, valor2, maior, id;



        #endregion

        #region MetodosInterface

        public void SetValor1(int v1)
        {

            valor1 = v1;
        }

        public void SetValor2(int v2)
        {

            valor2 = v2;

        }
        public void SetMaior(int m)
        {

            maior = m;

        }
       

        public int GetValor1()
        {
        
        return valor1;
        
        }

        public int GetValor2()
        {
        
        return valor2;
        
        }

        public int GetMaior()
        {
        
         return maior;
        
        }
      

        #endregion

        #region MetodosFuncionais

        public void MaiorNum() 
        {
            if (valor1 > valor2) maior = valor1;
            else maior = valor2;

        }
        public void Iguais()
        {
            maior = valor1;
            maior = valor2;
        }
       


        #endregion




    }

}


