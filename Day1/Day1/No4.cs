using System;
using System.Collections.Generic;
using System.Text;

namespace Day1
{
    class No4
    {
        static void no4()
        {
            string x = Console.ReadLine();
            string y = Console.ReadLine();

            int _x = int.Parse(x);
            int _y = int.Parse(y);

            int ans = (_x + _y) * (_x + _y);

            if(ans % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}
