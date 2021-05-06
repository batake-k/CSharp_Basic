using System;

namespace ConsoleApp1
{
    class Slot
    {
        static void Main(string[] args)
        {
            BaseMachine machine = new MachineA(100);
            machine.run();

            Console.WriteLine(machine.getPrize());
        }
    }
}
