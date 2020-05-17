using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_1
{
    class Program
    {
        public static void pokaz(Liczby X)
        {
            Console.WriteLine(X.get_a() + ", " + X.get_b() + ", " + X.get_c());
        }

        public static void pokaz(Lepsze_Liczby X)
        {
            Console.WriteLine(X.get_a() + ", " + X.get_b() + ", " + X.get_c()+", "+X.get_d());
        }

        static void Main(string[] args)
        {
            Liczby L1 = new Liczby();
            Liczby L2 = new Liczby();

            L1.set_a(1);
            L1.set_b(2);
            L1.set_c(3);

            L2.set_a(10);
            L2.set_b(20);
            L2.set_c(30);

            Lepsze_Liczby LL1 = new Lepsze_Liczby();
           
            LL1.set_a(100);
            LL1.set_b(200);
            LL1.set_c(300);
            LL1.set_d(400);

            Console.Write("L1:  "); pokaz(L1);
            Console.Write("L2:  "); pokaz(L2);
            Console.Write("LL1: "); pokaz(LL1);
           
            Console.ReadKey();
        }
    }
}
