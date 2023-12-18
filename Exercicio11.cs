using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_POOex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vtriangulo v;
            v = new Vtriangulo();
            int a, b, c;

            Console.WriteLine("=============================================  Soma e classificação de triângulos  ===================================================================");
            Console.WriteLine();
            Console.WriteLine("Entre com o primeiro valor ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Entre com o segundo valor");
            a = int.Parse(Console.ReadLine());  
            Console.WriteLine();
            Console.WriteLine(" Entre com o terceiro valor ");
            c = int.Parse(Console.ReadLine());

            v.SetBase0(a);
            v.SetLado1(b);
            v.SetLado2(c);
            v.Verifica();
            Console.WriteLine();
            if (a + b > c || b + c > a || a + c > b)
            {
                Console.WriteLine("", v.GetBase0(), v.GetLado1(), v.GetLado2(), v.GetResultado());

            }
            else
            {
                Console.WriteLine("Não é um triângulo");
            }









































            


        }
    }
}
