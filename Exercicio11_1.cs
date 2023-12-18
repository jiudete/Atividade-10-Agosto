using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Lista_POOex11
{
    internal class Vtriangulo
    {

        #region Atributos 
        private int lado1, lado2, base0, resultado;

        #endregion

        #region Metodosinterface
        public void SetLado1(int a)
        {
            lado1 = a;
        }
        public void SetLado2(int b)
        {
            lado2 = b;

        }
        public void SetBase0(int c)
        {
            base0 = c;
        }
        public int GetLado1()

        {
            return lado1;

        }
        public int GetLado2()
        {
            return lado2;

        }
        public int GetBase0()
        {
            return base0;

        }
        public int GetResultado()
        {
            return resultado;
        }


        #endregion


        #region MetodosFuncionais 


        public void Verifica()
        {
            resultado = lado1 + lado2 + base0;


            if (lado1 == lado2 && lado2 == base0)
            {

                Console.WriteLine(" É um triângulo equilátero ");
            }
            else if
              (lado1 != lado2 && lado2 == base0 || base0 != lado2 && base0 == lado1 || lado2 != base0 && lado2 == lado1)
            { 
                Console.WriteLine(" É um triângulo isóceles ");
            }           
            else 
            {
                Console.WriteLine(" Triangulo escaleno");
            }
        }
        #endregion

    }
}



























    
















































