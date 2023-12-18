using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_POOex10
{
    internal class Program
    {
        static void Main()
        {
            CalcularImc imc;
            imc = new CalcularImc();
            double p;
            double a;
          
            Console.WriteLine("  #############################################   CÁCULO DE IMC   ##################################################");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" Informe o peso");
            p = double.Parse(Console.ReadLine());
            Console.WriteLine();
         
            Console.WriteLine(" Informe a altura ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();
            imc.SetPeso(p);
            imc.SetAltura(a);
            imc.ResultadoImc();
           

            Console.WriteLine("Seu imc é {2}",imc.GetPeso(), imc.GetAltura(), imc.GetImc() );
            Console.WriteLine();
            Console.WriteLine();
            if (imc.GetImc() < 20)
            {
                Console.WriteLine("  Você está abaixo do peso");
            }
            if (imc.GetImc() > 20 && imc.GetImc() <= 25) 
            {
                Console.WriteLine(" Seu peso está ideal ");
            }if (imc.GetImc() > 25)
            {
                Console.WriteLine(" Você está acima do peso");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("########################################################################################################################");
























        }












          


























    }   
}
