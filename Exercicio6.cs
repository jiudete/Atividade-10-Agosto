using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_POOex6
{
    internal class Program
    {
        static void Main()
        {

            CotaDollar c;
            c = new CotaDollar();
            double cd;
            double d;
            int e;
      



            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$   CONVERSOR DE DOLLAR EM REAL  $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();



            Console.WriteLine(" Entre com a atual cotação do Dollar ");
            cd = double.Parse(Console.ReadLine());
            Console.WriteLine(" Entre com a quantia desejada para conversão");
            d = double.Parse(Console.ReadLine());


            c.SetCd(cd);
            c.SetD(d);
            c.Conversor();
            Console.WriteLine(" A cotação do Dollar atual é R${0} , o valor da quantia digitada foi ${1} , valor convertido R${2}", c.GetCd(), c.GetD(), c.GetConverter());
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine();
            Console.WriteLine();









            do
            {
                Console.WriteLine(" Deseja fazer uma nova corversão? \n -1 para nova conversão \n  2-  para encerrar ");

                Console.WriteLine(" Escolha uma opção ");
                e = int.Parse(Console.ReadLine());








                if (e == 1)
                {

                    Console.WriteLine(" Sua opção " + e);

                    Console.WriteLine(" Entre com a nova cotação do Dollar ");
                    cd = double.Parse(Console.ReadLine());
                    Console.WriteLine(" Entre com a  nova quantia desejada para conversão");
                    d = double.Parse(Console.ReadLine());
                    c = new CotaDollar();
                    c.SetCd(cd);
                    c.SetD(d);
                    c.Conversor();


                    Console.WriteLine(" A  nova cotação foi de R${0} , o valor da quantia digitada foi ${1} , valor convertido R${2}", c.GetCd(), c.GetD(), c.GetConverter());








                }
                else if (e == 2)
                {

                    Console.WriteLine(" Sua opção " + e);
                    Console.WriteLine(" Encerrando");

                }
                else Console.WriteLine("Opção inválida");

            } while (e != 2);

           


                     Console.WriteLine();
                     Console.WriteLine();
                     Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");











        }

    }       
}
