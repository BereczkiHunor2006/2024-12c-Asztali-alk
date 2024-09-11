using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TobbElem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Első feladat");
            int a = 0;
            int paros = 0;
            int paratlan = 0;
            while (true)
            {
                Console.Write("Kérek egy számot: ");
                int b = Convert.ToInt32(Console.ReadLine());
                a += b;
                if (b % 2 == 0)
                {
                    paros++;
                }
                else
                {
                    paratlan++;
                }
                if (b > 100)
                {
                    break;
                }
            }
            Console.WriteLine("Páros: " + paros + "Páratlan: " + paratlan);
            Console.ReadLine();
            
        }
    }
}
