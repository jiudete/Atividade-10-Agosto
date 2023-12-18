using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_POOex12
{
    internal class SomaTriangulo 

    {
        #region Atributos

        private double c1, c2, hp,calculo;
        #endregion

        #region MetodosInterface 
        public void SetC1(int c)
        { 
            c1 = c;        
        }
        public void SetC2(int c)
        { 
            c2 = c;
        }
        public void SetHp(int h)
        { 
         hp = h;
        }
        public double GetC1()
        { 
            return c1;
        }
        public double GetC2() 
        { 
            return c2;
        }
        public double GetHp()
        {
            return hp;
        }
        public double GetCalculo()    
        { 
        return calculo;
        }
        #endregion

        #region MetodosFuncionais
        public void Somar()
        {
            calculo = Math.Pow(c1, 2) + Math.Pow(c2, 2);
            if (calculo == Math.Pow(hp, 2)) 
            {
                Console.WriteLine(" É um triângulo retângulo");
            }
            else
            {
                Console.WriteLine(" Não é um triângulo retângulo");
            }


            #endregion

        }


    }
}
