using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_POOex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Area c;
            c = new Area();
            int l1, l2;
            int seleção;

            Console.WriteLine();
            Console.WriteLine("==================================== Comparativo de terreno ==============================================");
            Console.WriteLine(" Digite um lado ");
            l1 = int.Parse(Console.ReadLine());
            Console.WriteLine(" Digite outro lado ");
            l2 = int.Parse(Console.ReadLine());

            c.Setb(l1);
            c.Seth(l2);
            c.Calcular();

            Console.WriteLine("A área do Terreno é {2}", c.Getb(), c.Geth(), c.Geta());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("==========================================================================================================");
            Console.WriteLine();
            Console.WriteLine();
            do
            {
                Console.WriteLine(" Deseja comparar novamente?  \n 1- sim  \n 2- não e encerrar ");
                seleção = int.Parse(Console.ReadLine());

                if (seleção == 1)


                {
                    Console.WriteLine(" Sua Opção " + seleção);
                    Console.WriteLine(" Digite novamente um lado ");
                    l1 = int.Parse(Console.ReadLine());
                    Console.WriteLine(" Digite novamente  outro lado ");
                    l2 = int.Parse(Console.ReadLine());

                    c.Setb(l1);
                    c.Seth(l2);
                    c.Calcular();

                    Console.WriteLine("A área do Terreno é {2}", c.Getb(), c.Geth(), c.Geta());
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("==========================================================================================================");

                }

                if (seleção == 2)

                {
                    Console.WriteLine(" Sua Opção " + seleção);
                    Console.WriteLine(" Encerrando ");
                }
            }
            while (seleção != 2);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("==========================================================================================================");

        }
    }
}




