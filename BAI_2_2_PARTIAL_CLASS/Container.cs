using System;
using System.Collections.Generic;
using System.Text;

namespace BAI_2_2_PARTIAL_CLASS
{
    public class Container
    {
        public class Nester
        {
            public int a;
            public Nester(int a)
            {
               this.a = a;
            }
            public void inA()
            {
                Console.WriteLine($"a = {a}");
            }
        }
    }
}
