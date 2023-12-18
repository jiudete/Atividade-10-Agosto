using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lista_POOex7
{
    internal class MaiorNum

    #region Atributos
    {
        private int p1, p2, maior;


        #endregion
        #region MetodosInterface


        public void SetP1(int a)
        {

            p1 = a;

        }

        public void SetP2(int b) 
        { 

            p2 = b; 
        
        }

        public int GetP1()
        { 
            return p1; 
        }

        public  int GetP2() 
        {
            return p2;
        }

        public int GetMaior()
        {
            return maior;   
        }

        #endregion
        #region MetodosFuncionais 

        public void Comparar()
        {
            if (p1 <= p2) maior = p2;
            if (p2 <= p1) maior = p1;          
            
        }
        
        #endregion












    }
}

