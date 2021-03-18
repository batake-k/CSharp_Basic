using System;

namespace Day1
{
    class No1
    {
        static string program_var = "sample #1";
        static void no1(string[] args)
        {
            Console.WriteLine(program_var);
            Console.Write("お名前は？ >> ");
            string name = Console.ReadLine();
            Console.WriteLine($"ようこそ、{name}さん!");
        }
    }
}
