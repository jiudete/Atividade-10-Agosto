using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_POOex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MaiorNum m;
            m = new MaiorNum();


                    int n1;
                    int n2;
                    int n3;
            
      
               Console.WriteLine("________________________________________| Qual número é maior? |______________________________________________________");
               Console.WriteLine();
               Console.WriteLine();
               Console.WriteLine("Digite o primeiro número ");
                    n1 = int.Parse(Console.ReadLine());
               Console.WriteLine("Digite o segundo número ");
                    n2 = int.Parse(Console.ReadLine());


                    m.SetP1(n1);
                    m.SetP2(n2);
                    m.Comparar();
             
                Console.WriteLine("Os valores digitados foram {0} , e {1} portanto o maior número é {2} ", m.GetP1(), m.GetP2(), m.GetMaior());
                Console.WriteLine();
               

            do
            {
                
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("________________________________________________________________________________________________________________________");
                Console.WriteLine("Deseja fazer outra comparação?");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("escolha uma opção \n 1 - Nova comparação  \n 0 -Finalizar ");
                n3 = int.Parse(Console.ReadLine());
                Console.WriteLine(" Sua opção " + n3);
                Console.WriteLine();
                Console.WriteLine();
               

                if (n3 == 1)
                {
                    Console.WriteLine("Digite novamente o primeiro número ");
                    n1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite  novamente o segundo número ");
                    n2 = int.Parse(Console.ReadLine());
                    m.SetP1(n1);
                    m.SetP2(n2);
                    m.Comparar();
                    Console.WriteLine("Os valores digitados foram {0} , e {1} portanto o maior número é {2} ", m.GetP1(), m.GetP2(), m.GetMaior());

                }
                if (n3 == 0)
                {

                    Console.WriteLine(" Sua opção " + n3);
                    Console.WriteLine(" Finalizando, até mais!");

                }


                if (n3 != 1 && n3 != 0)

                {

                    Console.WriteLine(" Opção inválida");
                    Console.WriteLine(" Escolha novamente");


                }

            } while (n3 != 0 );

          
        }
    }
}
