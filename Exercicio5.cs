using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_POOex5
{
    internal class Program
    {
        static void Main()
        {
            int milhas = 0;
            double n = 0;
            MilhaKm t;
            t = new MilhaKm();
            Console.WriteLine("**************************************\\\\CONVERSOR DE MILHA MARÍTIMA EM KILOMETRO/////****************************************");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Digite um valor a ser convertido");
            milhas = int.Parse(Console.ReadLine());

            t.SetMilhas(milhas);
            t.Converter();

            Console.WriteLine("A distancia em milhas são {0} convertidas se tornam {1} kilometros ", t.GetMilhas(), t.GetConversao());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();




            Console.WriteLine(" Ecolha uma opção : \n 1- Novo valor \n 2- encerrar");

            while (n != 2)
            {

                Console.WriteLine(" Escolha uma opção");
                n = int.Parse(Console.ReadLine());



                if (n == 1)
                {
                    Console.WriteLine(" Sua opção " + n);
                    Console.WriteLine("Digite um novo valor a ser convertido");
                    milhas = int.Parse(Console.ReadLine());

                    t.SetMilhas(milhas);
                    t.Converter();

                    Console.WriteLine("A distancia em milhas Marítimas  são {0} convertidas se tornam {1} kilometros ", t.GetMilhas(), t.GetConversao());

                }
                else if (n == 2)
                {

                    Console.WriteLine(" Sua opção " + n);
                    Console.WriteLine(" Encerrando até mais ");

                }

                else
                {
                    Console.WriteLine("opção invalida");


                }

               
                Console.WriteLine("**********************************************************************************************************************");

            }
     
        }

    }         
    
}



                
            

















