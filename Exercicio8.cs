using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_POOex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Numeros n;
            n = new Numeros();
            int escolha1, escolha2, seletor;

            Console.WriteLine("=========================================== Maior ou igual ? ==========================================================");
            Console.WriteLine();
            Console.WriteLine(" Digite o primeiro número");
            escolha1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            escolha2 = int.Parse(Console.ReadLine());

            n.SetValor1(escolha1);
            n.SetValor2(escolha2);
            n.MaiorNum();



            if (escolha1 != escolha2)



              Console.WriteLine(" Os numeros digitados foram {0} , e {1}  sendo assim o mair número é {2}", n.GetValor1(), n.GetValor2(), n.GetMaior());


            if (escolha1 == escolha2)

            {
                Console.WriteLine(" Os números são idênticos ");
            }
            do
            {
                Console.WriteLine(" Deseja fazer uma nova operação?  \n 1- sim  \n-2 finalizar ");

                seletor = int.Parse(Console.ReadLine());
                if (seletor == 1)
                {
                    Console.WriteLine(" Digite o primeiro número");
                    escolha1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número");
                    escolha2 = int.Parse(Console.ReadLine());

                    n.SetValor1(escolha1);
                    n.SetValor2(escolha2);
                    n.MaiorNum();



                    if (escolha1 != escolha2)



                        Console.WriteLine(" Os numeros digitados foram {0} , e {1}  sendo assim o mair número é {2}", n.GetValor1(), n.GetValor2(), n.GetMaior());


                    if (escolha1 == escolha2)

                    {
                        Console.WriteLine(" Os números são idênticos ");
                    }
                }
                    else
                    { 
                
                     Console.WriteLine(" Finalizando");
                
                    }
            } while (seletor != 2);
















































        }       

    }   }    

