using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_POOex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SomaTriangulo s;
            s = new SomaTriangulo();
            int c1, c2, h, seletor;
            Console.WriteLine(" Digite o primeiro cateto");
            c1 = int.Parse(Console.ReadLine());
            Console.WriteLine(" Digete o segundo cateto");
            c2 = int.Parse(Console.ReadLine());
            Console.WriteLine(" Digite a hipotenusa");
            h = int.Parse(Console.ReadLine());
            s.SetC1(c1);
            s.SetC2(c2);
            s.SetHp(h);
            s.Somar();

            Console.WriteLine("", s.GetC1(), s.GetC2(), s.GetCalculo(), s.GetHp());

            do
            {
                Console.WriteLine(" Repetir a operação?  \n 1-sim   \n 2- não e encerrar.");
                seletor = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if (seletor == 1)
                {
                    Console.WriteLine(" Digite o primeiro cateto");
                    c1 = int.Parse(Console.ReadLine());
                    Console.WriteLine(" Digete o segundo cateto");
                    c2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(" Digite a hipotenusa");
                    h = int.Parse(Console.ReadLine());
                    s.SetC1(c1);
                    s.SetC2(c2);
                    s.SetHp(h);
                    s.Somar();
                    Console.WriteLine("", s.GetC1(), s.GetC2(), s.GetCalculo(), s.GetHp());
                }
                else
                {
                    Console.WriteLine(" encerrando");
                }
            }
            while (seletor != 2);
        }
    }
}
