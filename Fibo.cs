using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_in_C_
{
    internal class Fibo
    {
        public Fibo() {
            int a = 0;
            int b = 1;
            int c = 1;

            int d = 5;
            Console.WriteLine(a);
            Console.WriteLine(b);
            for (int i = 0; i < d; i++) {
                int sum = a + b;
                Console.WriteLine(sum);
                a = b; 
                b = sum; 
            }

        }

    }
}
