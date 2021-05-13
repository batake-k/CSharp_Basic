using System;

namespace ConsoleApp1
{
    class Slot
    {
        static void Main(string[] args)
        {
            int bet = 100;

            BaseMachine machine = null;

            while (true)
            {
                System.Console.WriteLine("please enter the slot type.(A,B,C)");
                var type = System.Console.ReadLine();

                if (type == "A")
                {
                    machine = new MachineA(bet);
                    break;
                }
                else if (type == "B")
                {
                    machine = new MachineB(bet);
                    break;
                }
                else if (type == "C")
                {
                    machine = new MachineC(bet);
                    break;
                }

            }

            while (true)
            {
                Console.WriteLine("remain: " + machine.getPrize());
                System.Console.WriteLine("please enter your action. (r: run, g: get credit)");
                var action = System.Console.ReadLine();

                if(action == "r")
                {
                    if (machine.run())
                    {

                    }
                    else
                    {
                        Console.WriteLine("it's end. bye.");
                        break;
                    }
                }
                else if(action == "g")
                {
                    break;
                }
            }

        }
    }
}
