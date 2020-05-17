using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace Lab3_1
{
    public class Lepsze_Liczby : Liczby
    {
        protected int d;
        
        public Lepsze_Liczby()
        {
            this.d = 0;
            Console.WriteLine("Konstruktor - LL: " + this.get_a() +", "+ this.get_b()+", "+this.get_c()+", "+this.get_d());
            Console.ReadKey();
        }
       
        public int get_d() { return this.d; }
        public void set_d(int x) { this.d=x; }

    }
}