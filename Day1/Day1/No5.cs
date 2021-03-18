using System;
using System.Collections.Generic;
using System.Text;

namespace Day1
{
    class No5
    {
        static void no5()
        {
            for(int i=1; i<=50; ++i)
            {
                if(i % 3 == 0)
                {
                    Console.WriteLine(i);
                }else if (i%10 == 3 || i/10 == 3)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
