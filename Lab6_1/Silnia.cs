using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_1
{
    public class Silnia
    {
        public int Oblicz(int s)
        {
            if (s < 2)
                return 1;
            else
            {
                return s * Oblicz(s - 1);
            }
        }
    }
}
