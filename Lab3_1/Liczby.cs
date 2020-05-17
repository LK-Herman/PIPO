using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3_1
{
    public class Liczby
    {
        public Liczby()
        {
            this.a = 0;
            this.b = 0;
            this.c = 0;
        }

        private int a;
        private int b;
        private int c;
        
        public int get_a() {return a;}
        public int get_b() {return b;}
        public int get_c() {return c;}

        public void set_a(int x) { this.a = x;}
        public void set_b(int x) { this.b = x;}
        public void set_c(int x) { this.c = x; }
    }
}